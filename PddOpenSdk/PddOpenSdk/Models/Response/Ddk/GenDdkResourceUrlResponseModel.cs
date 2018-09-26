using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GenDdkResourceUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 单人团链接
        /// </summary>
        [JsonProperty("single_url_list")]
        public SingleUrlListResponseModel SingleUrlList { get; set; }
        /// <summary>
        /// 多人团链接
        /// </summary>
        [JsonProperty("multi_url_list")]
        public MultiUrlListResponseModel MultiUrlList { get; set; }
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        public partial class SingleUrlListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 频道推广长链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            /// <summary>
            /// 频道推广短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒拼多多APP长链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒拼多多APP短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒微信长链接
            /// </summary>
            [JsonProperty("we_app_web_view_url")]
            public string WeAppWebViewUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒微信短链接
            /// </summary>
            [JsonProperty("we_app_web_view_short_url")]
            public string WeAppWebViewShortUrl { get; set; }
            /// <summary>
            /// 小程序信息
            /// </summary>
            [JsonProperty("we_app_page_path")]
            public string WeAppPagePath { get; set; }

        }
        public partial class MultiUrlListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 频道推广长链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            /// <summary>
            /// 频道推广短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒拼多多APP长链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒拼多多APP短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒微信长链接
            /// </summary>
            [JsonProperty("we_app_web_view_url")]
            public string WeAppWebViewUrl { get; set; }
            /// <summary>
            /// 频道推广唤醒微信短链接
            /// </summary>
            [JsonProperty("we_app_web_view_short_url")]
            public string WeAppWebViewShortUrl { get; set; }
            /// <summary>
            /// 小程序红包推广路径
            /// </summary>
            [JsonProperty("we_app_page_path")]
            public string WeAppPagePath { get; set; }

        }

    }

}
