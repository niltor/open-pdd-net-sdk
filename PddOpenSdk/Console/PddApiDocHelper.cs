using Console.PddModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    /// <summary>
    /// 拼多多接口获取帮助类
    /// </summary>
    public class PddApiDocHelper
    {
        /// <summary>
        /// 分类列表
        /// </summary>
        private readonly string ListUrl = "https://open-api.pinduoduo.com/pop/doc/category/list";

        /// <summary>
        /// 某分类下接口列表
        /// </summary>
        private readonly string CatUrl = "https://open-api.pinduoduo.com/pop/doc/info/list/byCat";

        /// <summary>
        /// 接口详情内容
        /// </summary>
        private readonly string DocInfoUrl = "https://open-api.pinduoduo.com/pop/doc/info/get";

        public List<PddCatInfo> PddCatInfos { get; set; }
        public List<PddDocInfo> PddDocInfos { get; set; }
        /// <summary>
        /// 目录与类名映射
        /// </summary>
        public Dictionary<string, string> CatMapClassName = new Dictionary<string, string>();

        public PddApiDocHelper()
        {
            #region 初始化映射类名
            CatMapClassName.Add("1", "Order");
            CatMapClassName.Add("2", "Refund");
            CatMapClassName.Add("3", "Logistics");
            CatMapClassName.Add("4", "Virtual");
            CatMapClassName.Add("5", "Goods");

            CatMapClassName.Add("12", "Ddk");
            CatMapClassName.Add("13", "DdkTools");
            CatMapClassName.Add("14", "LogisticsCompany");
            CatMapClassName.Add("15", "Promotion");
            CatMapClassName.Add("16", "Voucher");
            CatMapClassName.Add("17", "Invoice");
            CatMapClassName.Add("18", "Mall");

            CatMapClassName.Add("20", "Util");
            CatMapClassName.Add("21", "Stock");
            CatMapClassName.Add("22", "Pmc");
            CatMapClassName.Add("23", "WayBill");
            CatMapClassName.Add("24", "Finance");
            CatMapClassName.Add("26", "OpenMsg");
            CatMapClassName.Add("30", "ServiceMarket");
            CatMapClassName.Add("32", "SmsVendor");

            CatMapClassName.Add("35", "User");
            CatMapClassName.Add("41", "Ad");
            CatMapClassName.Add("43", "Fds");
            CatMapClassName.Add("46", "Mall");
            CatMapClassName.Add("48", "Oversea");
            CatMapClassName.Add("49", "Ticket");

            // === 待定
            //CatMapClassName.Add("51", "");

            // === 以下取消
            //CatMapClassName.Add("32", "Sms");
            //CatMapClassName.Add("27", "Xinzhi");

            #endregion
        }

        /// <summary>
        /// 获取当前分类列表
        /// </summary>
        /// <returns></returns>
        public async Task<List<PddCatInfo>> GetCatListAsync()
        {
            using var hc = new HttpClient();
            try
            {
                var response = await hc.GetStringAsync(ListUrl);
                var result = JsonConvert.DeserializeObject<ListResponseModel>(response);
                return result.Result;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return default;
            }
        }

        /// <summary>
        /// 获取某类别下接口列表
        /// </summary>
        /// <param name="id">类别id</param>
        /// <returns></returns>
        public async Task<List<PddDocInfo>> GetApiDocListByCatAsync(long id)
        {
            using (var hc = new HttpClient())
            {
                var requestContent = new StringContent(JsonConvert.SerializeObject(new { id }), Encoding.UTF8,
                                                       "application/json");
                var response = await hc.PostAsync(CatUrl, requestContent);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<CatListResponseModel>(json);
                    return result.Result.DocList;
                }
            }
            return null;
        }

        /// <summary>
        /// 获取接口详细信息
        /// </summary>
        /// <param name="id">类别id</param>
        /// <returns></returns>
        public async Task<ApiDocDetail> GetDocDetailByIdAsync(string id)
        {
            using (var hc = new HttpClient())
            {
                var requestContent = new StringContent(JsonConvert.SerializeObject(new { id }), Encoding.UTF8,
                                                       "application/json");
                var response = await hc.PostAsync(DocInfoUrl, requestContent);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ApiDocResponseModel>(json, ParamTypeConverter.Singleton);
                    return result.Result;
                }
            }
            return null;
        }

        public async Task TestApi(string id)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Services", "PddApi");
            // 创建目录
            if (!Directory.Exists(resultPath))
            {
                Directory.CreateDirectory(resultPath);
            }
            var docDetail = await GetDocDetailByIdAsync(id);
            string className = docDetail.ScopeName;
            className = className.Split(".")[1] ?? "UnNamed";
            string methodsContent = BuildRequestMethod(docDetail, className);
            SaveApiClass(className, methodsContent);
        }
        /// <summary>
        /// 全量生成所有接口模型及请求类
        /// </summary>
        /// <returns></returns>
        public async Task Run(bool isUpdate = false)
        {
            int totalNumber = 0;
            PddCatInfos = await GetCatListAsync();
            if (PddCatInfos.Count > 0)
            {

                var currentPath = Directory.GetCurrentDirectory();
                var resultPath = Path.Combine(currentPath, "Services", "PddApi");
                // 创建目录
                if (!Directory.Exists(resultPath))
                {
                    Directory.CreateDirectory(resultPath);
                }

                foreach (var pddCatInfo in PddCatInfos)
                {

                    PddDocInfos = await GetApiDocListByCatAsync(pddCatInfo.Id);

                    // 获取映射类名
                    CatMapClassName.TryGetValue(pddCatInfo.Id.ToString(), out string className);
                    if (PddDocInfos.Count > 0)
                    {
                        string methodsContent = "";
                        className ??= "UnNamed";
                        foreach (var pddDocInfo in PddDocInfos)
                        {
                            totalNumber++;
                            // 是否只获取更新的接口
                            if (isUpdate)
                            {
                                if (!pddDocInfo.ScopeTips.ToLower().Equals("new"))
                                {
                                    continue;
                                }
                            }
                            var docDetail = await GetDocDetailByIdAsync(pddDocInfo.Id);
                            methodsContent += BuildRequestMethod(docDetail, className);
                            System.Console.WriteLine($"[{totalNumber}]" + docDetail.ScopeName + "...Done!");

                        }
                        SaveApiClass(className, methodsContent);
                    }
                }
            }
        }


        /// <summary>
        /// 生成接口请求方法
        /// </summary>
        /// <param name="requestClassName">请求类名称</param>
        /// <param name="doc"></param>
        public string BuildRequestMethod(ApiDocDetail doc, string requestClassName = "")
        {
            // 方法命名
            var scopeName = doc.ScopeName.Split('.');
            var methodName = Function.ToPascalCase(scopeName.Last());
            for (int i = 1; i < scopeName.Length - 1; i++)
            {
                methodName += Function.ToPascalCase(scopeName[i]);
            }
            // 方法参数
            string methodComment =
$@"/// <summary>
/// {doc.ApiName}
/// </summary>
";
            string methodParams;

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
                File.AppendAllText("error.txt", doc.ScopeName + "; catId:" + doc.CatId + doc.ResponseCodeExample + "\r\n");
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
        public string BuildRequestModel(string className, List<ParamList> paramLists, int parentId = 0)
        {
            if (string.IsNullOrEmpty(className))
            {
                return default;
            }

            className = className.Replace("$", "");

            var currentParamLists = paramLists.Where(p => p.ParentId == parentId).ToList();
            string content = "";
            content = Function.AppendLine(content, $"public partial class {className} : PddRequestModel");
            content = Function.AppendLine(content, "{");
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {
                // 对文件属性名进行特殊处理
                if (param.ParamType == ParamType.File)
                {
                    param.ParamName = "file_path";
                }

                var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), param.IsMust.Value);

                var paramName = Function.ToPascalCase(param.ParamName.Replace("_", " "))?.Replace(" ", "")?.Replace("$", "");
                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0)
                {
                    childClass += BuildRequestModel(paramName + "RequestModel", paramLists, (int)param.Id);
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
        public string BuildResponseModel(string className, List<ParamList> paramLists, int parentId = 0)
        {
            if (string.IsNullOrEmpty(className))
            {
                return default;
            }

            var currentParamLists = paramLists.Where(p => p.ParentId == parentId).ToList();
            string content = "";
            content = Function.AppendLine(content, $"public partial class {className} : PddResponseModel");
            content = Function.AppendLine(content, "{");
            string paramsContent = "";
            string childClass = "";
            foreach (var param in currentParamLists)
            {

                var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), 0, "ResponseModel");
                var paramName = Function.ToPascalCase(param.ParamName.Replace("_", " "))?.Replace(" ", "")?.Replace("$", "");
                // 如果是对象类型，生成子类模型
                if (param.ChildrenNum > 0)
                {
                    childClass += BuildResponseModel(paramName + "ResponseModel", paramLists, (int)param.Id);
                }
                // 参数注释
                var paramComment =
$@"/// <summary>
/// {param.ParamDesc?.Replace("\n", "; ")}
/// </summary>
[JsonProperty(""{param.ParamName}"")]
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

            if (!string.IsNullOrEmpty(dir))
            {
                dir = "." + dir;
            }

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

            if (!string.IsNullOrEmpty(dir))
            {
                dir = "." + dir;
            }

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

            string fileName = Function.ToPascalCase(className) + "Api";
            // 处理重复类名的情况

            string content = $@"
using PddOpenSdk.Models.Request.{Function.ToPascalCase(className)};
using PddOpenSdk.Models.Response.{Function.ToPascalCase(className)};
using System.Threading.Tasks;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{{
    public class {fileName} : PddCommonApi {{
        public {fileName}(){{}}
        public {fileName}(string clientId, string clientSecret, string accessToken): base(clientId, clientSecret, accessToken){{}}
        {classContent}
    }}
}}
";
            File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), content);

        }

        /// <summary>
        /// 转换参数类型为C#表达
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected string ConvertParamType(ParamType type)
        {
            string result = string.Empty;
            switch (type)
            {
                case ParamType.Double:
                    result = "double";
                    break;
                case ParamType.Integer:
                    result = "int";
                    break;
                case ParamType.IntegerArray:
                    result = "int[]";
                    break;
                case ParamType.Long:
                    result = "long";
                    break;
                case ParamType.LongArray:
                    result = "long[]";
                    break;
                case ParamType.Object:
                    result = "object";
                    break;
                case ParamType.ObjectArray:
                    result = "object[]";
                    break;
                case ParamType.StringArray:
                    result = "string[]";
                    break;
                case ParamType.String:
                    result = "string";
                    break;
                case ParamType.Boolean:
                    result = "boolean";
                    break;
                case ParamType.Map:
                    result = "map";
                    break;
                case ParamType.MapArray:
                    result = "map[]";
                    break;
                case ParamType.File:
                    result = "string";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
