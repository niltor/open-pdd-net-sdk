namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class AuthServiceMailOrderFc
{

    /// <summary>
    /// 拼接到url的参数
    /// </summary>
    [JsonPropertyName("urlParams")]
    public UrlParamsModel UrlParams { get; set; }

    /// <summary>
    /// 请求方法
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string HttpMethod { get; set; }
    public partial class UrlParamsModel
    {

        /// <summary>
        /// 丰巢开平app_key
        /// </summary>
        [JsonPropertyName("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 丰巢开平app_secret
        /// </summary>
        [JsonPropertyName("app_secret")]
        public string AppSecret { get; set; }

    }

}

