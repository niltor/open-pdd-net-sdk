using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public partial class GenDdkOauthLotteryUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        /// <summary>
        /// 推广链接
        /// </summary>
        [JsonProperty("url_list")]
        public UrlListResponseModel UrlList { get; set; }
        public partial class UrlListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 转盘抽免单单人团链接
            /// </summary>
            [JsonProperty("single_url_list")]
            public SingleUrlListResponseModel SingleUrlList { get; set; }
            /// <summary>
            /// 转盘抽免单多人团链接
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
                /// 转盘抽免单长链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// 转盘抽免单短链接
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒APP长链接
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒APP短链接
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒微信长链接
                /// </summary>
                [JsonProperty("we_app_web_view_url")]
                public string WeAppWebViewUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒微信短链接
                /// </summary>
                [JsonProperty("we_app_web_view_short_url")]
                public string WeAppWebViewShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单小程序短链接
                /// </summary>
                [JsonProperty("we_app_page_path")]
                public string WeAppPagePath { get; set; }

            }
            public partial class MultiUrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 转盘抽免单长链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// 转盘抽免单短链接
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒拼多多APP长链接
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒拼多多APP短链接
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒微信长链接
                /// </summary>
                [JsonProperty("we_app_web_view_url")]
                public string WeAppWebViewUrl { get; set; }
                /// <summary>
                /// 转盘抽免单唤醒微信短链接
                /// </summary>
                [JsonProperty("we_app_web_view_short_url")]
                public string WeAppWebViewShortUrl { get; set; }
                /// <summary>
                /// 转盘抽免单小程序链接
                /// </summary>
                [JsonProperty("we_app_page_path")]
                public string WeAppPagePath { get; set; }

            }

        }

    }

}
