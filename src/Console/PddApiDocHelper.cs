

namespace Console;

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
        CatMapClassName.Add("18", "MallShop");

        CatMapClassName.Add("20", "Util");
        CatMapClassName.Add("21", "Stock");
        CatMapClassName.Add("22", "Pmc");
        CatMapClassName.Add("23", "WayBill");
        CatMapClassName.Add("24", "Finance");
        CatMapClassName.Add("26", "OpenMsg");
        CatMapClassName.Add("30", "ServiceMarket");
        CatMapClassName.Add("32", "SmsVendor");

        //CatMapClassName.Add("35", "User");
        CatMapClassName.Add("41", "Ad");
        CatMapClassName.Add("43", "Fds");
        CatMapClassName.Add("46", "Mall");
        CatMapClassName.Add("48", "Oversea");
        CatMapClassName.Add("49", "Ticket");
        //CatMapClassName.Add("54", "PictureTool");

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
            var result = JsonSerializer.Deserialize<ListResponseModel>(response);
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
            var requestContent = new StringContent(JsonSerializer.Serialize(new { id }), Encoding.UTF8,
                                                   "application/json");
            var response = await hc.PostAsync(CatUrl, requestContent);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CatListResponseModel>(json);
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
            var requestContent = new StringContent(JsonSerializer.Serialize(new { id }), Encoding.UTF8,
                                                   "application/json");
            var response = await hc.PostAsync(DocInfoUrl, requestContent);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ApiDocResponseModel>(json);
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
            await Parallel.ForEachAsync(PddCatInfos, new ParallelOptions {
                MaxDegreeOfParallelism = 3
            }, async (pddCatInfo, token) => {
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
                                return;
                            }
                        }
                        var docDetail = await GetDocDetailByIdAsync(pddDocInfo.Id);
                        methodsContent += BuildRequestMethod(docDetail, className);
                        System.Console.WriteLine($"[{totalNumber}]" + docDetail.ScopeName + "...Done!");
                    }
                    SaveApiClass(className, methodsContent);
                }
            });
            System.Console.WriteLine("Get All " + totalNumber + " done!");
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
$@"
        /// <summary>
        /// {doc.ApiName}
        /// </summary>
";
        string methodParams;

        // 创建请求模型类
        string paramsModelType = methodName;
        string requestContent = BuildRequestModel(paramsModelType, doc.RequestParamList);
        SaveRequestModel(paramsModelType, requestContent, requestClassName);
        string paramsModelName = methodName.First().ToString().ToLower() + methodName[1..];
        methodParams = paramsModelType + " " + paramsModelName;

        // 创建返回模型类
        string responseModelName = methodName + "Response";
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

        var postName = "PostAsync";
        // 如果是文件类型
        if (doc.RequestParamList.Any(p => p.ParamType == "FILE"))
        {
            postName = "PostFileAsync";
        }
        return @$"      {methodComment}public async Task<{responseModelName}> {methodName}Async({methodParams})
        {{
            var result = await {postName}<{paramsModelType}, {responseModelName}>(""{doc.ScopeName}"", {paramsModelName});
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

        string suffix = "Model";
        var currentParamLists = paramLists.Where(p => p.ParentId == parentId).ToList();
        string content = "";
        content = Function.AppendLine(content, $"\tpublic partial class {className}");
        content = Function.AppendLine(content, "\t{");
        string paramsContent = "";
        string childClass = "";
        foreach (var param in currentParamLists)
        {
            // 对文件属性名进行特殊处理
            if (param.ParamType == "FILE")
            {
                param.ParamName = "file_path";
            }

            var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), param.IsMust.Value, suffix, hasChild: param.ChildrenNum > 0);

            var paramName = Function.ToPascalCase(param.ParamName.Replace("_", " "))?.Replace(" ", "")?.Replace("$", "");
            // 如果是对象类型，生成子类模型
            if (param.ChildrenNum > 0)
            {
                childClass += BuildRequestModel(paramName + suffix, paramLists, (int)param.Id);
            }

            // 参数注释
            var paramComment =
$@"
    /// <summary>
    /// {param.ParamDesc?.Replace("\n", "; ")}
    /// </summary>
    [JsonPropertyName(""{param.ParamName}"")]
";
            paramsContent += paramComment + "\t" + attribution;
        }
        content += paramsContent;
        content += childClass + Environment.NewLine;
        content += "\t}" + Environment.NewLine;
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
        content = Function.AppendLine(content, $"\tpublic partial class {className} : PddResponseModel");
        content = Function.AppendLine(content, "\t{");
        string paramsContent = "";
        string childClass = "";
        foreach (var param in currentParamLists)
        {

            var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), 0, "Response", param.ChildrenNum > 0);

            var paramName = Function.ToPascalCase(param.ParamName.Replace("_", " "))?.Replace(" ", "")?.Replace("$", "");
            // 如果是对象类型，生成子类模型
            if (param.ChildrenNum > 0)
            {
                childClass += BuildResponseModel(paramName + "Response", paramLists, (int)param.Id);
            }
            // 参数注释
            var paramComment =
$@"
    /// <summary>
    /// {param.ParamDesc?.Replace(Environment.NewLine, "; ")}
    /// </summary>
    [JsonPropertyName(""{param.ParamName}"")]
";

            paramsContent += paramComment + attribution;
            //System.Console.WriteLine(paramType + " " + paramName);
        }
        content += paramsContent;
        content += childClass + Environment.NewLine;
        content += "\t}" + Environment.NewLine;
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
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Models", "Request", dir);
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

        string namespaceBlock = Function.AppendLine("", $"using PddOpenSdk.Models.Request;");
        namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Request{dir};");
        classContent = Function.AppendLine(classContent, namespaceBlock, true);
        string fileName = className;
        File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
    }

    /// <summary>
    /// 自动生成接口返回类
    /// </summary>
    protected void SaveResponseModel(string className, string classContent, string dir = "")
    {
        var currentPath = Directory.GetCurrentDirectory();
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Models", "Response", dir);
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

        string namespaceBlock = Function.AppendLine("", "using PddOpenSdk.Models.Response;");
        namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Response{dir};");
        classContent = Function.AppendLine(classContent, namespaceBlock, true);

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
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Services", "PddApi");

        string fileName = Function.ToPascalCase(className) + "Api";
        // 处理重复类名的情况

        string content = $@"
using PddOpenSdk.Models.Request.{Function.ToPascalCase(className)};
using PddOpenSdk.Models.Response.{Function.ToPascalCase(className)};
namespace PddOpenSdk.Services.PddApi;
public class {fileName} : PddCommonApi {{
    public {fileName}(){{}}
    public {fileName}(string clientId, string clientSecret, string accessToken): base(clientId, clientSecret, accessToken){{}}
    {classContent}
}}
";
        File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), content);

    }

    /// <summary>
    /// 生成PddService服务类
    /// </summary>
    public async Task GeneratePddServiceClassAsync()
    {
        // 1 获取说明注释
        var catList = await GetCatListAsync();
        // 2 构造属性
        var propsContent = "\t\tpublic AuthApi AuthApi { get; }" + Environment.NewLine;
        catList.ForEach(cat => {
            var comment = $"\t\t/// <summary>" + Environment.NewLine
                + $"\t\t/// {cat.Name}" + Environment.NewLine
                + "\t\t/// </summary>" + Environment.NewLine;
            var propName = CatMapClassName.GetValueOrDefault(cat.Id.ToString());
            if (!string.IsNullOrEmpty(propName))
            {
                var prop = $"\t\tpublic {propName}Api {propName}Api {{ get; }}" + Environment.NewLine;
                propsContent += comment + prop;
            }
        });

        // 3 构造构造方法/options/set token
        string ctorContent = "AuthApi = new AuthApi(_options.ClientId, _options.ClientSecret, _options.AccessToken, _options.CallbackUrl);" + Environment.NewLine;
        string ctorOptionConent = "AuthApi = new AuthApi(options.ClientId, options.ClientSecret, options.AccessToken, options.CallbackUrl);" + Environment.NewLine;
        string setTokenContent = "";
        CatMapClassName.ToList().ForEach(cat => {
            var apiName = cat.Value + "Api";
            ctorContent += "\t\t\t" + apiName + $" = new {apiName}(_options.ClientId, _options.ClientSecret, _options.AccessToken);" + Environment.NewLine;
            ctorOptionConent += "\t\t\t" + apiName + $" = new {apiName}(options.ClientId, options.ClientSecret, options.AccessToken);" + Environment.NewLine;
            setTokenContent += "\t\t\t" + apiName + ".AccessToken = accessToken;" + Environment.NewLine;
        });
        // 4 替换并写入
        var path = Path.Combine(Environment.CurrentDirectory, "PddService.cs.tpl");
        if (File.Exists(path))
        {
            var tplContent = File.ReadAllText(path);
            tplContent = tplContent.Replace("{{$Properties}}", propsContent)
                .Replace("{{$Ctor}}", ctorContent)
                .Replace("{{$CtorOption}}", ctorOptionConent)
                .Replace("{{$SetToken}}", setTokenContent);

            var currentPath = Directory.GetCurrentDirectory();
            var servicePath = Path.Combine(currentPath, "..", "AspNetCore", "PddService.cs");
            File.WriteAllText(servicePath, tplContent);
        }
    }

    /// <summary>
    /// 转换参数类型为C#表达
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    protected string ConvertParamType(string type)
    {
        return type.ToLower() switch {
            "file" => "string",
            "integer" => "int",
            "integer[]" => "int[]",
            "void" => "string",
            _ => type.ToLower(),
        };
    }
}
