using Newtonsoft.Json;
using System.Globalization;
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
                    //var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<PddDocListModel>(json);
                    if (result.Success.Value)
                    {
                        var docList = result.Result.DocList;
                        foreach (var doc in docList)
                        {
                            System.Console.WriteLine(MethodBuild(doc));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 生成方法
        /// </summary>
        /// <param name="doc"></param>
        public string MethodBuild(ApiDoc doc)
        {
            // 方法命名
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            var scopeName = doc.ScopeName.Split('.');
            var methodName = myTI.ToTitleCase(scopeName.Last());
            for (int i = 1; i < scopeName.Length - 1; i++)
            {
                methodName += myTI.ToTitleCase(scopeName[i]);
            }
            // 方法参数

            var requestParamList = doc.RequestParamList.OrderByDescending(r => r.IsMust).ToList();
            string methodComment = $@"/// <summary>
/// {doc.ApiName}
/// </summary>
"; ;
            string methodParams = "";

            foreach (var item in requestParamList)
            {
                string paramName = myTI.ToTitleCase(item.ParamName.Replace("_", " "));

                string paramComment = $@"/// <param name=""{paramName.Replace(" ","")}"">{item.ParamDesc}</param>
";
                paramName = item.ParamType.ToLower() + " " + paramName.Replace(" ", "") + ",";
                methodParams += paramName;
                methodComment += paramComment;
            }
            methodParams = "(" + methodParams.Substring(0, methodParams.Length - 1) + ")";


            // TODO: 处理返回类型
            string returnType = "";

            return $@"{methodComment}public async Task<{returnType}> {methodName}Async{methodParams}
{{
    var result = pddRequest.Post({doc.ScopeName});
    return JsonConvert.DeserializeObject<{returnType}>(result);
}}";

        }
    }
}
