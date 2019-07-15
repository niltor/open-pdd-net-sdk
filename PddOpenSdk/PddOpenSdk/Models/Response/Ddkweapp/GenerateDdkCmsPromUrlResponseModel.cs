using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ddkweapp
{
    public partial class GenerateDdkCmsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商城推广链接返回对象
        /// </summary>
        [JsonProperty("cms_promotion_url_generate_response")]
        public CmsPromotionUrlGenerateResponseResponseModel CmsPromotionUrlGenerateResponse { get; set; }
        public partial class CmsPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            /// <summary>
            /// 链接列表
            /// </summary>
            [JsonProperty("url_list")]
            public List<UrlListResponseModel> UrlList { get; set; }
            public partial class UrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 多人团唤醒微信推广长链接
                /// </summary>
                [JsonProperty("multi_we_app_web_view_url")]
                public string MultiWeAppWebViewUrl { get; set; }
                /// <summary>
                /// 双人团链接列表
                /// </summary>
                [JsonProperty("multi_url_list")]
                public MultiUrlListResponseModel MultiUrlList { get; set; }
                /// <summary>
                /// 多人团唤醒拼多多app链接
                /// </summary>
                [JsonProperty("multi_group_mobile_short_url")]
                public string MultiGroupMobileShortUrl { get; set; }
                /// <summary>
                /// 唤醒拼多多app链接
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// CPSsign
                /// </summary>
                [JsonProperty("sign")]
                public string Sign { get; set; }
                /// <summary>
                /// 多人团唤醒微信推广短链接
                /// </summary>
                [JsonProperty("multi_we_app_web_view_short_url")]
                public string MultiWeAppWebViewShortUrl { get; set; }
                /// <summary>
                /// 多人团唤醒拼多多app长链接
                /// </summary>
                [JsonProperty("multi_group_mobile_url")]
                public string MultiGroupMobileUrl { get; set; }
                /// <summary>
                /// h5长链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// h5短链接
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 单人团链接列表
                /// </summary>
                [JsonProperty("single_url_list")]
                public SingleUrlListResponseModel SingleUrlList { get; set; }
                /// <summary>
                /// 多人团长链
                /// </summary>
                [JsonProperty("multi_group_url")]
                public string MultiGroupUrl { get; set; }
                /// <summary>
                /// 多人团短链
                /// </summary>
                [JsonProperty("multi_group_short_url")]
                public string MultiGroupShortUrl { get; set; }
                /// <summary>
                /// 唤醒拼多多app短链
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 唤醒微信长链
                /// </summary>
                [JsonProperty("we_app_web_view_url")]
                public string WeAppWebViewUrl { get; set; }
                /// <summary>
                /// 唤醒微信短链
                /// </summary>
                [JsonProperty("we_app_web_view_short_url")]
                public string WeAppWebViewShortUrl { get; set; }
                public partial class MultiUrlListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 双人团唤醒拼多多app长链接
                    /// </summary>
                    [JsonProperty("mobile_url")]
                    public string MobileUrl { get; set; }
                    /// <summary>
                    /// 双人团唤醒拼多多app短链接
                    /// </summary>
                    [JsonProperty("mobile_short_url")]
                    public string MobileShortUrl { get; set; }
                    /// <summary>
                    /// 双人团唤醒微信链接
                    /// </summary>
                    [JsonProperty("we_app_web_view_url")]
                    public string WeAppWebViewUrl { get; set; }
                    /// <summary>
                    /// 双人团长链接
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; }
                    /// <summary>
                    /// 双人团短链接
                    /// </summary>
                    [JsonProperty("short_url")]
                    public string ShortUrl { get; set; }
                    /// <summary>
                    /// 双人团唤醒微信短链接
                    /// </summary>
                    [JsonProperty("we_app_web_view_short_url")]
                    public string WeAppWebViewShortUrl { get; set; }

                }
                public partial class SingleUrlListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 唤醒拼多多app长链接
                    /// </summary>
                    [JsonProperty("mobile_url")]
                    public string MobileUrl { get; set; }
                    /// <summary>
                    /// 唤醒拼多多app短链接
                    /// </summary>
                    [JsonProperty("mobile_short_url")]
                    public string MobileShortUrl { get; set; }
                    /// <summary>
                    /// 唤醒微信链接
                    /// </summary>
                    [JsonProperty("we_app_web_view_url")]
                    public string WeAppWebViewUrl { get; set; }
                    /// <summary>
                    /// 长链接
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; }
                    /// <summary>
                    /// 短链接
                    /// </summary>
                    [JsonProperty("short_url")]
                    public string ShortUrl { get; set; }
                    /// <summary>
                    /// 唤醒微信短链接
                    /// </summary>
                    [JsonProperty("we_app_web_view_short_url")]
                    public string WeAppWebViewShortUrl { get; set; }

                }

            }

        }

    }

}
