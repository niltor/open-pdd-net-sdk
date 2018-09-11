using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    /// <summary>
    /// 拼多多请求
    /// </summary>
    public class PddRequest
    {
        /// <summary>
        /// 请求接口
        /// </summary>
        readonly string ApiUrl = "https://gw-api.pinduoduo.com/api/router";
        /// <summary>
        /// access_token
        /// </summary>
        readonly string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";
        /// <summary>
        /// 平台提供
        /// </summary>
        readonly string ClientId = "";
        /// <summary>
        /// 平台提供
        /// </summary>
        readonly string ClientSecret = "";
        /// <summary>
        /// 商家授权地址
        /// </summary>
        private readonly string MmsURL = "https://mms.pinduoduo.com/open.html";
        /// <summary>
        /// 移动端授权地址
        /// </summary>
        private readonly string MaiURL = "https://mai.pinduoduo.com/h5-login.html";
        /// <summary>
        /// 多多客授权地址
        /// </summary>
        private readonly string DDKUrl = "https://jinbao.pinduoduo.com/open.html";

        protected static HttpClient client = new HttpClient();

        public PddRequest()
        {
        }

        /// <summary>
        /// 获取请求
        /// </summary>
        /// <param name="code"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        protected string GetAccessToken(string code, string redirectUrl, string state = null)
        {
            if (code != null && redirectUrl != null)
            {
                var dic = new Dictionary<string, string>
                {
                    { "client_id", ClientId },
                    { "client_secret", ClientSecret },
                    { "grant_type", "authorization_code" },
                    { "code", code },
                    { "redirect_uri", redirectUrl }
                };
                if (state != null)
                {
                    dic.Add("state", state);
                }

                var data = new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, "application/json");

            }
            return default;
        }

        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        protected async Task<T> PostAsync<T>(string type, Dictionary<string, string> dic)
        {
            // TODO 合并字典
            var data = new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(ApiUrl, data);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(jsonResult);
                if (jObject.TryGetValue("error_response", out var errorResponse))
                {
                    // TODO:记录异常
                    System.Console.WriteLine(errorResponse["error_code"].ToString() + errorResponse["error_msg"]);
                    return default;
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(jsonResult);
                }

            }
            return default;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <returns></returns>
        protected string BuildSign()
        {
            return default;
        }

        /// <summary>
        /// 获取网页授权地址
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public string GetWebOAuthUrl(string callbackUrl, string state = null)
        {
            string url = MmsURL + "?response_type=code&client_id=" + ClientId + "&redirect_url=" + callbackUrl;
            if (!string.IsNullOrEmpty(state))
            {
                url += "&state=" + state;
            }
            return url;
        }
        /// <summary>
        /// 获取移动网页授权地址
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public string GetH5OAuthUrl(string callbackUrl, string state = null)
        {
            string url = MaiURL + "?response_type=code&client_id=" + ClientId + "&redirect_url=" + callbackUrl + "&view=h5";
            if (!string.IsNullOrEmpty(state))
            {
                url += "&state=" + state;
            }
            return url;
        }
        /// <summary>
        /// 多多客授权
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public string GetDDKOAuthUrl(string callbackUrl, string state = null)
        {
            string url = DDKUrl + "?response_type=code&client_id=" + ClientId + "&redirect_url=" + callbackUrl;
            if (!string.IsNullOrEmpty(state))
            {
                url += "&state=" + state;
            }
            return url;
        }
    }

    /// <summary>
    /// 公共请求参数
    /// </summary>
    public class CommonReqeustParams
    {
        /// <summary>
        /// API接口名称
        /// </summary>
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// POP分配给应用的client_id
        /// </summary>
        [Required]
        public string Client_Id { get; set; }
        /// <summary>
        /// 通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        /// UNIX时间戳
        /// </summary>
        [Required]
        public string TimeStamp { get; set; }
        /// <summary>
        /// 响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
        /// </summary>
        public string Data_Type { get; set; } = "JSON";

        public string Version { get; set; } = "V1";
        /// <summary>
        /// API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部
        /// </summary>
        [Required]
        public string Sign { get; set; }

    }
}
