using Newtonsoft.Json;
using PddOpenSdk.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PddOpenSdk.Services.PddApi
{
    public class AuthApi : PddCommonApi
    {
        /// <summary>
        /// access_token
        /// </summary>
        public static readonly string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";
        /// <summary>
        /// 商家授权地址
        /// </summary>
        public static readonly string MmsURL = "https://mms.pinduoduo.com/open.html";
        /// <summary>
        /// 移动端授权地址
        /// </summary>
        public static readonly string MaiURL = "https://mai.pinduoduo.com/h5-login.html";
        /// <summary>
        /// 多多客授权地址
        /// </summary>
        public static readonly string DDKUrl = "https://jinbao.pinduoduo.com/open.html";


        public AuthApi()
        {

        }

        /// <summary>
        /// 获取Token请求
        /// </summary>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public async Task<AccessTokenResponseModel> GetAccessTokenAsync(string code, string state = null)
        {
            if (code != null)
            {
                // TODO 先读取未过期token，若已过期，则刷新或重新获取
                var dic = new Dictionary<string, string>
                {
                    { "client_id", ClientId },
                    { "client_secret", ClientSecret },
                    { "grant_type", "authorization_code" },
                    { "code", code },
                    { "redirect_uri", RedirectUri }
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
                    System.Console.WriteLine(jsonString);
                    var result = JsonConvert.DeserializeObject<AccessTokenResponseModel>(jsonString);

                    //AccessToken = result.AccessToken;
                    return result;
                }
            }
            return default;
        }

        /// <summary>
        /// 获取刷新Token请求
        /// </summary>
        /// <param name="refresh_token">刷新授权</param>
        /// <param name="state"></param>
        /// <returns></returns>
        public async Task<AccessTokenResponseModel> GetRefreshTokenAsync(string refresh_token, string state = null)
        {
            if (refresh_token != null)
            {
                // TODO 先读取未过期token，若已过期，则刷新或重新获取
                var dic = new Dictionary<string, string>
                {
                    { "client_id", ClientId },
                    { "client_secret", ClientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", refresh_token }
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
                    System.Console.WriteLine(jsonString);
                    var result = JsonConvert.DeserializeObject<AccessTokenResponseModel>(jsonString);

                    return result;
                }
            }
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
        public string GetDDKOAuthUrl(string state = null)
        {
            string url = DDKUrl + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + RedirectUri;
            if (!string.IsNullOrEmpty(state))
            {
                url += "&state=" + state;
            }
            return url;
        }
    }
}
