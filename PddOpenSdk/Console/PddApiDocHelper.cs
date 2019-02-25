using Console;
using Msdev.JsonToClass;
using Msdev.JsonToClass.CodeWriters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                                className = Function.ToTitleCase(className) + Function.ToTitleCase(secondName);
                            }

                            foreach (var doc in docList)
                            {
                                methodsContent += BuildRequestMethod(doc, className);
                            }
                            SaveApiClass(className, methodsContent);

                        }
                    }
                }
            }
        }

        /// <summary>
        /// 生成接口请求方法
        /// </summary>
        /// <param name="requestClassName">请求类名称</param>
        /// <param name="doc"></param>
        public string BuildRequestMethod(ApiDoc doc, string requestClassName = "")
        {
            requestClassName = Function.ToTitleCase(requestClassName);
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
            SaveRequestModel(paramsModelType, requestContent, requestClassName);
            string paramsModelName = methodName.First().ToString().ToLower() + methodName.Substring(1);
            methodParams = paramsModelType + " " + paramsModelName;

            // 创建返回模型类
            string responseModelName = methodName + "ResponseModel";
            // 根据返回示例生成
            string responseContent = BuildResponseModel(responseModelName, doc.ResponseParamList);
            if (string.IsNullOrEmpty(responseContent))
            {
                responseContent = BuildResponseModel(responseModelName, doc.ResponseParamList);
            }

            if (string.IsNullOrEmpty(responseContent))
            {
                File.AppendAllText("error.txt", doc.ScopeName + "; catId:" + doc.CatId + doc.CodeExample + "\r\n");
            }
            SaveResponseModel(responseModelName, responseContent, requestClassName);

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
            content = Function.AppendLine(content, $"public partial class {className} : PddRequestModel");
            content = Function.AppendLine(content, "{");
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {

                var attribution = NameHelper.GetAttributionName(param.ParamName, param.ParamType, param.IsMust.Value);
                var paramName = Function.ToTitleCase(param.ParamName.Replace("_", " "))?.Replace(" ", "");
                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0)
                {
                    childClass += BuildRequestModel(paramName + "RequestModel", paramLists, (int)param.Level + 1, (int)param.Id);
                }

                // 参数注释
                var paramComment =
$@"/// <summary>
/// {param.ParamDesc?.Replace("\n", "; ")}
/// </summary>
[JsonProperty(""{param.ParamName}"")]
";
                paramsContent += paramComment + attribution;
            }
            content += paramsContent;
            content += childClass + "\r\n";
            content += "}\r\n";
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
            content = Function.AppendLine(content, $"public partial class {className} : PddResponseModel");
            content = Function.AppendLine(content, "{");
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {
                // TODO 注意：拼多多，响应 内容与类型及描述字段对应混乱
                var attribution = NameHelper.GetAttributionName(param.ParamType, param.ParamDesc, 0, "ResponseModel");
                var paramName = Function.ToTitleCase(param.ParamType.Replace("_", " "))?.Replace(" ", "");
                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0)
                {
                    childClass += BuildResponseModel(paramName + "ResponseModel", paramLists, (int)param.Level + 1, (int)param.Id);
                }
                // 参数注释
                var paramComment =
$@"/// <summary>
/// {param.ParamName?.Replace("\n", "; ")}
/// </summary>
[JsonProperty(""{param.ParamType}"")]
";

                paramsContent += paramComment + attribution;
                //System.Console.WriteLine(paramType + " " + paramName);
            }
            content += paramsContent;
            content += childClass + "\r\n";
            content += "}\r\n";
            return content;
        }

        /// <summary>
        /// json转class
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        protected string JsonToClass(string className, string json, string dir = "")
        {
            if (string.IsNullOrEmpty(json)) return default;
            if (!string.IsNullOrEmpty(dir)) dir = "." + dir;
            var gen = new JsonClassGenerator
            {
                UsePascalCase = true,
                MainClass = className,
                UseNestedClasses = false,
                UseProperties = true,
                CodeWriter = new CSharpCodeWriter(),
                //Namespace = "PddOpenSdk.Models.Response",
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
        protected void SaveRequestModel(string className, string classContent, string dir = "")
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Models", "Request", dir);
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

            if (!string.IsNullOrEmpty(dir)) dir = "." + dir;
            string namespaceBlock = Function.AppendLine("", "using System.Collections.Generic;");
            namespaceBlock = Function.AppendLine(namespaceBlock, "using Newtonsoft.Json;");
            namespaceBlock = Function.AppendLine(namespaceBlock, $"using PddOpenSdk.Models.Request;");
            namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Request{dir}");
            namespaceBlock = Function.AppendLine(namespaceBlock, "{");
            classContent = Function.AppendLine(classContent, namespaceBlock, true);
            classContent = Function.AppendLine(classContent, "}");
            string fileName = className;
            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
        }

        /// <summary>
        /// 自动生成接口返回类
        /// </summary>
        protected void SaveResponseModel(string className, string classContent, string dir = "")
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Models", "Response", dir);
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

            if (!string.IsNullOrEmpty(dir)) dir = "." + dir;
            string namespaceBlock = Function.AppendLine("", "using System.Collections.Generic;");
            namespaceBlock = Function.AppendLine(namespaceBlock, "using Newtonsoft.Json;");
            namespaceBlock = Function.AppendLine(namespaceBlock, "using PddOpenSdk.Models.Response;");
            namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Response{dir}");
            namespaceBlock = Function.AppendLine(namespaceBlock, "{");
            classContent = Function.AppendLine(classContent, namespaceBlock, true);
            classContent = Function.AppendLine(classContent, "}");

            string fileName = className;
            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
        }
        /// <summary>
        /// 保存接口请求类
        /// </summary>
        /// <param name="className"></param>
        protected void SaveApiClass(string className, string classContent)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Services", "PddApi");

            string fileName = Function.ToTitleCase(className) + "Api";
            // 处理重复类名的情况

            string content = $@"using PddOpenSdk.Models.Request;
using PddOpenSdk.Models.Response;
using PddOpenSdk.Models.Request.{Function.ToTitleCase(className)};
using PddOpenSdk.Models.Response.{Function.ToTitleCase(className)};
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
