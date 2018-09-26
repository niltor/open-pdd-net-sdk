using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Msdev.JsonToClass;
using Msdev.JsonToClass.CodeWriters;
using Newtonsoft.Json;

namespace Sample
{
    /// <summary>
    /// 拼多多接口获取帮助类
    /// </summary>
    public class PddApiDocHelper
    {
        readonly string CatApiUrl = "http://open-api.pinduoduo.com/pop/doc/list/by/cat";

        /// <summary>
        /// 获取分类下所有文档列表
        /// </summary>
        public async Task GetDocListByCatAsync(int catId = 1)
        {
            using (var hc = new HttpClient())
            {

                var requestContent = new StringContent(JsonConvert
                    .SerializeObject(new
                    {
                        id = catId
                    }), Encoding.UTF8, "application/json");

                var response = await hc.PostAsync(CatApiUrl, requestContent);
                var json = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<PddDocListModel>(json);
                    if (result.Success.Value)
                    {
                        string methodsContent = "";
                        var docList = result.Result.DocList;

                        // 取第一个作为类名
                        var className = docList?.FirstOrDefault()?.ScopeName;
                        if (className != null)
                        {
                            // 用来避免重复名称
                            var secondName = className.Split(".")[2] ?? "UnNamed";
                            className = className.Split(".")[1] ?? "UnNamed";
                            foreach (var doc in docList)
                            {
                                methodsContent += BuildRequestMethod(doc);
                            }
                            className = Function.ToTitleCase(className);
                            SaveApiClass(className, methodsContent, secondName);

                        }
                    }
                }
            }
        }

        /// <summary>
        /// 生成接口请求方法
        /// </summary>
        /// <param name="doc"></param>
        public string BuildRequestMethod(ApiDoc doc)
        {
            // 方法命名
            var scopeName = doc.ScopeName.Split('.');
            var methodName = Function.ToTitleCase(scopeName.Last());
            for (int i = 1; i < scopeName.Length - 1; i++)
            {
                methodName += Function.ToTitleCase(scopeName[i]);
            }
            // 方法参数
            string methodComment =
$@"/// <summary>
/// {doc.ApiName}
/// </summary>
";
            string methodParams = "";

            // 创建请求模型类
            string paramsModelType = methodName + "RequestModel";
            string requestContent = BuildRequestModel(paramsModelType, doc.RequestParamList);
            SaveRequestModel(paramsModelType, requestContent);
            string paramsModelName = methodName.First().ToString().ToLower() + methodName.Substring(1);
            methodParams = paramsModelType + " " + paramsModelName;

            // 创建返回模型类
            string responseModelName = methodName + "ResponseModel";
            // 根据返回示例生成
            string responseContent = JsonToClass(responseModelName, doc.CodeExample);
            if (string.IsNullOrEmpty(responseContent))
            {
                responseContent = BuildResponseModel(responseModelName, doc.ResponseParamList);
            }

            if (string.IsNullOrEmpty(responseContent))
            {
                File.AppendAllText("error.txt", doc.ScopeName + "; catId:" + doc.CatId + doc.CodeExample + "\r\n");
            }
            SaveResponseModel(responseModelName, responseContent);

            return $@"{methodComment}public async Task<{responseModelName}> {methodName}Async({methodParams})
{{
    var result = await PostAsync<{paramsModelType},{responseModelName}>(""{doc.ScopeName}"",{paramsModelName});
    return result;
}}
";
        }

        /// <summary>
        /// 生成请求类型
        /// </summary>
        /// <param name="paramLists"></param>
        /// <param name="className"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public string BuildRequestModel(string className, List<ParamList> paramLists, int level = 1, int parentId = 0)
        {
            if (string.IsNullOrEmpty(className))
                return default;

            var currentParamLists = paramLists.Where(p => p.Level == level && p.ParentId == parentId).ToList();

            string content = "";
            if (level == 1)
            {
                content += @"using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{";
            }
            content +=
$@"
    public partial class {className} : PddRequestModel
    {{
        ";
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {
                // 参数名
                var paramName = Function.ToTitleCase(param.ParamName?.Replace("_", " "))?.Replace(" ", "");
                // 参数类型
                var paramType = param.ParamType;
                switch (paramType.ToLower())
                {
                    case "integer":
                    case "number":
                        paramType = param.IsMust == 0 ? "int?" : "int";
                        break;
                    case "boolean":
                        paramType = param.IsMust == 0 ? "bool?" : "bool";
                        break;
                    case "jsonstring":
                        paramType = paramName + "RequestModel";
                        break;
                    case "list":
                        paramType = "object[]";
                        break;
                    case "":
                        paramType = "object";
                        break;
                    default:
                        if (paramType.ToLower().StartsWith("string"))
                        {
                            paramType = "string";
                        }
                        else
                        {
                            paramType = "object";
                        }
                        break;
                }
                // 数组类型特殊处理
                if (param.ParamType.Equals(param.ParamType + "[]") || param.ParamType.Equals("[]"))
                {
                    paramType = $"List<{paramType}>";
                }

                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0 || param.ParamType.ToLower().Equals("jsonstring"))
                {
                    childClass += BuildRequestModel(paramName + "RequestModel", paramLists, (int)param.Level + 1, (int)param.Id);
                    paramType = paramName + "RequestModel";
                }

                // 参数注释
                var paramComment =
$@"/// <summary>
/// {param.ParamDesc?.Replace("\n", "; ")}
/// </summary>
[JsonProperty(""{param.ParamName}"")]
";
                paramsContent += paramComment + $"public {paramType} {paramName} {{get;set;}}\r\n";
            }
            content += paramsContent;
            content += childClass + "\r\n";
            content += level == 1 ? "}\r\n}\r\n" : "}\r\n";

            return content;

        }

        /// <summary>
        /// 生成响应类型
        /// </summary>
        /// <param name="className"></param>
        /// <param name="paramLists"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public string BuildResponseModel(string className, List<ParamList> paramLists, int level = 1, int parentId = 0)
        {
            if (string.IsNullOrEmpty(className))
                return default;
            var currentParamLists = paramLists.Where(p => p.Level == level && p.ParentId == parentId).ToList();

            string content = "";
            if (level == 1)
            {
                content += @"using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{";
            }
            content +=
$@"
    public partial class {className} : PddResponseModel
    {{
        ";
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {
                // TODO 注意：拼多多，响应内容内容字段存储混乱
                // 返回错误兼容
                if (param.ParamType.Contains("[]"))
                {
                    param.ParamType = param.ParamType.Replace("[]", "");
                }
                // 参数名
                var paramName = Function.ToTitleCase(param.ParamType?.Replace("_", " ")).Replace(" ", "");
                // 参数类型
                var paramType = param.ParamDesc;
                var orgType = param.ParamDesc;
                switch (paramType.ToLower())
                {
                    case "integer":
                    case "number":
                        paramType = param.IsMust == 0 ? "int?" : "int";
                        break;
                    case "boolean":
                        paramType = param.IsMust == 0 ? "bool?" : "bool";
                        break;
                    case "jsonstring":
                        paramType = paramName + "ResponseModel";
                        break;
                    case "list":
                        paramType = "object[]";
                        break;
                    case "":
                        paramType = "object";
                        break;
                    default:
                        if (paramType.ToLower().StartsWith("string"))
                        {
                            paramType = "string";
                        }
                        else
                        {
                            paramType = "object";
                        }
                        break;
                }
                // 数组类型特殊处理
                if (orgType.Equals(param.ParamType + "[]") || orgType.Equals("[]"))
                {
                    paramType = $"List<{paramType}>";
                }
                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0)
                {
                    childClass += BuildResponseModel(paramName + "ResponseModel", paramLists, (int)param.Level + 1, (int)param.Id);
                    paramType = paramName + "ResponseModel";
                }
                // 参数注释
                var paramComment =
$@"/// <summary>
/// {param.ParamName?.Replace("\n", "; ")}
/// </summary>
[JsonProperty(""{param.ParamType}"")]
";


                paramsContent += paramComment + $"public {paramType} {paramName} {{get;set;}}\r\n";
                //System.Console.WriteLine(paramType + " " + paramName);
            }
            content += paramsContent;
            content += childClass + "\r\n";
            content += level == 1 ? "}\r\n}\r\n" : "}\r\n";
            return content;
        }

        /// <summary>
        /// json转class
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        protected string JsonToClass(string className, string json)
        {
            if (string.IsNullOrEmpty(json)) return default;
            var gen = new JsonClassGenerator
            {
                UsePascalCase = true,
                MainClass = className,
                UseNestedClasses = false,
                UseProperties = true,
                CodeWriter = new CSharpCodeWriter(),
                Namespace = "PddOpenSdk.Models.PddApiResponse",
                Example = json,
                ExamplesInDocumentation = true
            };
            using (var sw = new StringWriter())
            {

                try
                {
                    gen.OutputStream = sw;
                    gen.GenerateClasses();
                    sw.Flush();
                    return sw.ToString();
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine(className);
                    return default;
                }

            }
        }

        /// <summary>
        /// 保存请求模型类
        /// </summary>
        /// <param name="className"></param>
        /// <param name="classContent"></param>
        protected void SaveRequestModel(string className, string classContent)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Models", "PddApiRequest");
            // 创建目录
            if (!Directory.Exists(resultPath))
            {
                Directory.CreateDirectory(resultPath);
            }
            // 处理content为空的情况
            if (string.IsNullOrEmpty(classContent))
            {
                classContent = $@"public class {className}{{}}";
            }
            string fileName = className;
            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
        }

        /// <summary>
        /// 自动生成接口返回类
        /// </summary>
        protected void SaveResponseModel(string className, string classContent)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Models", "PddApiResponse");
            // 创建目录
            if (!Directory.Exists(resultPath))
            {
                Directory.CreateDirectory(resultPath);
            }
            // 处理content为空的情况
            if (string.IsNullOrEmpty(classContent))
            {
                classContent = $@"public class {className}{{}}";
            }
            string fileName = className;
            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
        }
        /// <summary>
        /// 保存接口请求类
        /// </summary>
        /// <param name="className"></param>
        protected void SaveApiClass(string className, string classContent, string secondName = "")
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Services", "PddApi");
            // 创建目录
            if (!Directory.Exists(resultPath))
            {
                Directory.CreateDirectory(resultPath);
            }
            string fileName = Function.ToTitleCase(className) + "Api";
            // 处理重复类名的情况
            if (File.Exists(Path.Combine(resultPath, fileName + ".cs")))
            {
                fileName = Function.ToTitleCase(className) + Function.ToTitleCase(secondName) + "Api";
            }

            string content = $@"using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{{
    public class {fileName} : PddCommonApi {{
        {classContent}
    }}
}}
";

            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), content);

        }
    }
}
