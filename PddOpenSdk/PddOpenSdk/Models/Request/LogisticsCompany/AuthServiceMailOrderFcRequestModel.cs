using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.LogisticsCompany
{
    public partial class AuthServiceMailOrderFcRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼接到url的参数
        /// </summary>
        [JsonProperty("urlParams")]
        public UrlParamsRequestModel UrlParams { get; set; }
        /// <summary>
        /// 请求方法
        /// </summary>
        [JsonProperty("httpMethod")]
        public string HttpMethod { get; set; }
        public partial class UrlParamsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 丰巢开平app_key
            /// </summary>
            [JsonProperty("app_key")]
            public string AppKey { get; set; }
            /// <summary>
            /// 丰巢开平app_secret
            /// </summary>
            [JsonProperty("app_secret")]
            public string AppSecret { get; set; }

        }

    }

}
