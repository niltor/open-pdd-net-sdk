using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回链接
        /// </summary>
        [JsonProperty("url_list")]
        public UrlListResponseModel UrlList { get; set; }

        public partial class UrlListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 红包推广长链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            /// <summary>
            /// 红包推广短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }
            /// <summary>
            /// 红包推广唤醒拼多多APP长链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }
            /// <summary>
            /// 红包推广唤醒拼多多APP短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }
            /// <summary>
            /// 红包推广唤醒微信长链接
            /// </summary>
            [JsonProperty("we_app_web_view_url")]
            public string WeAppWebViewUrl { get; set; }
            /// <summary>
            /// 红包推广唤醒微信短链接
            /// </summary>
            [JsonProperty("we_app_web_view_short_url")]
            public string WeAppWebViewShortUrl { get; set; }
            /// <summary>
            /// 红包推广多人团长链接
            /// </summary>
            [JsonProperty("multi_group_url")]
            public string MultiGroupUrl { get; set; }
            /// <summary>
            /// 红包推广多人团短链接
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }
            /// <summary>
            /// 红包推广多人团唤醒APP长链接
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }
            /// <summary>
            /// 红包推广多人团唤醒APP短链接
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }
            /// <summary>
            /// 红包推广多人团唤醒微信长链接
            /// </summary>
            [JsonProperty("multi_we_app_web_view_url")]
            public string MultiWeAppWebViewUrl { get; set; }
            /// <summary>
            /// 红包推广多人团唤醒微信短链接
            /// </summary>
            [JsonProperty("multi_we_app_web_view_short_url")]
            public string MultiWeAppWebViewShortUrl { get; set; }
            /// <summary>
            /// 小程序信息
            /// </summary>
            [JsonProperty("we_app_info")]
            public WeAppInfoResponseModel WeAppInfo { get; set; }

            public partial class WeAppInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 小程序id
                /// </summary>
                [JsonProperty("app_id")]
                public string AppId { get; set; }
                /// <summary>
                /// icon的链接
                /// </summary>
                [JsonProperty("we_app_icon_url")]
                public string WeAppIconUrl { get; set; }
                /// <summary>
                /// banner图url
                /// </summary>
                [JsonProperty("banner_url")]
                public string BannerUrl { get; set; }
                /// <summary>
                /// 描述
                /// </summary>
                [JsonProperty("desc")]
                public string Desc { get; set; }
                /// <summary>
                /// 展示标题名
                /// </summary>
                [JsonProperty("source_display_name")]
                public string SourceDisplayName { get; set; }
                /// <summary>
                /// 跳转目标小程序地址
                /// </summary>
                [JsonProperty("page_path")]
                public string PagePath { get; set; }
                /// <summary>
                /// 用户名
                /// </summary>
                [JsonProperty("user_name")]
                public string UserName { get; set; }
                /// <summary>
                /// 小程序标题
                /// </summary>
                [JsonProperty("title")]
                public string Title { get; set; }

            }

        }

    }
}
