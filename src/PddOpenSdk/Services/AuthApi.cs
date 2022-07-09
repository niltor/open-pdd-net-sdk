
using PddOpenSdk.Models;

namespace PddOpenSdk.Services;

public class AuthApi : PddCommonApi
{
    /// <summary>
    /// access_token
    /// </summary>
    public readonly static string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";
    /// <summary>
    /// 商家授权地址
    /// </summary>
    public readonly static string MmsURL = "https://mms.pinduoduo.com/open.html";
    /// <summary>
    /// 店铺Web
    /// </summary>
    public readonly static string FuwuWebUrl = "https://fuwu.pinduoduo.com/service-market/auth";
    /// <summary>
    /// 移动端授权地址
    /// </summary>
    public readonly static string MaiURL = "https://mai.pinduoduo.com/h5-login.html";
    /// <summary>
    /// 多多客授权地址
    /// </summary>
    public readonly static string DDKUrl = "https://jinbao.pinduoduo.com/open.html";

    public AuthApi() { }
    public AuthApi(string clientId, string clientSecret, string accessToken, string redirectUrl)
        : base(clientId, clientSecret, accessToken)
    {
        RedirectUri = redirectUrl;
    }

    /// <summary>
    /// 获取Token请求
    /// </summary>
    /// <param name="code"></param>
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

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            using var hc = new HttpClient();
            var response = await hc.PostAsync(TokenUrl, data);
            ErrorResponse = new PddErrorResponseModel();

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jObject = JsonDocument.Parse(jsonString);
                if (jObject.RootElement.TryGetProperty("error_response", out var errorResponse))
                {
                    ErrorResponse = JsonSerializer.Deserialize<PddErrorResponseModel>(jsonString);
                    Console.WriteLine("错误信息:" + errorResponse.ToString());
                    return default;
                }
                else
                {
                    var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);
                    return result;
                }
            }
            else
            {
                Console.WriteLine("网络请求错误：" + response.ReasonPhrase + ":" + response.StatusCode);
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

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            using var hc = new HttpClient();
            var response = await hc.PostAsync(TokenUrl, data);
            var jsonString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(jsonString);
            var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);

            return result;
        }
        return default;
    }

    /// <summary>
    /// 获取网页授权地址
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public string GetWebOAuthUrl(string state = null)
    {
        var url = MmsURL + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + RedirectUri;
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
        var url = MaiURL + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + callbackUrl + "&view=h5";
        if (!string.IsNullOrEmpty(state))
        {
            url += "&state=" + state;
        }
        return url;
    }
    /// <summary>
    /// 多多客授权
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public string GetDDKOAuthUrl(string state = null)
    {
        var url = DDKUrl + "?response_type=code&client_id=" + ClientId + "&redirect_uri=" + RedirectUri;
        if (!string.IsNullOrEmpty(state))
        {
            url += "&state=" + state;
        }
        return url;
    }

}
