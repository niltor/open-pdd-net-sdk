using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PddOpenSdk.Common;
using PddOpenSdk.Models;

namespace PddOpenSdk.Services
{
    /// <summary>
    /// 拼多多请求
    /// </summary>
    public class PddApi
    {
        /// <summary>
        /// 请求接口
        /// </summary>
        static readonly string ApiUrl = "http://gw-api.pinduoduo.com/api/router";
        /// <summary>
        /// access_token
        /// </summary>
        static readonly string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";
        /// <summary>
        /// 平台提供
        /// </summary>
        readonly string ClientId = "224d8818907b438aab5262df5dfe6dde"; // TODO 配置中读取
        /// <summary>
        /// 平台提供
        /// </summary>
        readonly string ClientSecret = "d852c967bbdad36ae446ae84dfccf1c61b5a8d6f"; // TODO 配置中读取
        /// <summary>
        /// 回调地址
        /// </summary>
        readonly string RedirectUri = "http://pdd.guandian.tech/pdd/callback"; // TODO 配置中读取
        /// <summary>
        /// 商家授权地址
        /// </summary>
        private static readonly string MmsURL = "https://mms.pinduoduo.com/open.html";
        /// <summary>
        /// 移动端授权地址
        /// </summary>
        private static readonly string MaiURL = "https://mai.pinduoduo.com/h5-login.html";
        /// <summary>
        /// 多多客授权地址
        /// </summary>
        private static readonly string DDKUrl = "https://jinbao.pinduoduo.com/open.html";

        protected static HttpClient client = new HttpClient();
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken;

        public PddApi()
        {
        }
        public PddApi(string clientId, string clientSecret, string accessToken)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AccessToken = accessToken;
        }

        /// <summary>
        /// 获取请求
        /// </summary>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public async Task<AccessTokenResponseModel> GetAccessTokenAsync(string code, string redirectUri, string state = null)
        {
            if (code != null && redirectUri != null)
            {
                // TODO 先读取未过期token，若已过期，则刷新或重新获取
                var dic = new Dictionary<string, string>
                {
                    { "client_id", ClientId },
                    { "client_secret", ClientSecret },
                    { "grant_type", "authorization_code" },
                    { "code", code },
                    { "redirect_uri", redirectUri }
                };
                if (state != null)
                {
                    dic.Add("state", state);
                }

                var data = new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, "application/json");
                using (var hc = new HttpClient())
                {
                    var response = await hc.PostAsync(TokenUrl, data);
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<AccessTokenResponseModel>(jsonString);

                    return result;
                }
            }
            return default;
        }

        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        protected async Task<T> PostAsync<T>(string type, Dictionary<string, object> dic)
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
        /// post请求封装
        /// </summary>
        /// <typeparam name="TModel">请求参数类型</typeparam>
        /// <typeparam name="TResult">返回参数类型</typeparam>
        /// <param name="type"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected async Task<TResult> PostAsync<TModel, TResult>(string type, TModel model)
        {
            // 类型转换到字典
            var dic = Function.ToDictionary(model);
            // 添加公共参数
            dic.Add("access_token", AccessToken);
            dic.Add("client_id", ClientId);
            dic.Add("data_type", "JSON");
            dic.Add("versioin", "V1");
            dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            if (dic.Keys.Any(k => k == "type"))
            {
                dic.Remove("type");
                dic.Add("type", type);
            }
            // 添加签名
            dic.Add("sign", BuildSign(dic));

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
                    return JsonConvert.DeserializeObject<TResult>(jsonResult);
                }
            }
            return default;
        }
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public string BuildSign(Dictionary<string, object> dic)
        {
            // 去除空值并排序
            dic = dic.Where(d => d.Value != null)
                .OrderBy(d => d.Key)
                .ToDictionary((d) => d.Key, (d) => d.Value);
            // 拼接
            string signString = "";
            // 反射处理非基本类型字段的json转换
            string[] types = { "String", "DateTime", "Int", "Float", "Double" };
            foreach (var item in dic.Keys.ToArray())
            {
                if (!types.Contains(dic[item]?.GetType().Name))
                {
                    dic[item] = JsonConvert.SerializeObject(dic[item]);
                }
                signString += item + dic[item];
            }
            signString = ClientSecret + signString + ClientSecret;
            // MD5加密
            using (var md5 = MD5.Create())
            {
                signString = Function.GetMd5Hash(md5, signString).ToUpper();
            }
            return signString;
        }

        /// <summary>
        /// 获取网页授权地址
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public string GetWebOAuthUrl(string callbackUrl, string state = null)
        {
            string url = MmsURL + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + callbackUrl;
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
            string url = MaiURL + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + callbackUrl + "&view=h5";
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
            string url = DDKUrl + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + callbackUrl;
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
        public string Type { get; set; }
        /// <summary>
        /// POP分配给应用的client_id
        /// </summary>
        public string Client_Id { get; set; }
        /// <summary>
        /// 通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        /// UNIX时间戳
        /// </summary>
        public string TimeStamp { get; set; }
        /// <summary>
        /// 响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
        /// </summary>
        public string Data_Type { get; set; } = "JSON";
        public string Version { get; set; } = "V1";
        /// <summary>
        /// API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部
        /// </summary>
        public string Sign { get; set; }
    }
}
