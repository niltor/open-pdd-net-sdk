using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel {
        /// <summary>
        /// 红包推广链接返回对象
        /// </summary>
        [JsonProperty ("rp_promotion_url_generate_response")]
        public RpPromotionUrlGenerateResponseResponseModel RpPromotionUrlGenerateResponse { get; set; }
        public partial class RpPromotionUrlGenerateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// url_list
            /// </summary>
            [JsonProperty ("url_list")]
            public List<UrlListResponseModel> UrlList { get; set; }
            public partial class UrlListResponseModel : PddResponseModel {
                /// <summary>
                /// 红包推广链接
                /// </summary>
                [JsonProperty ("url")]
                public string Url { get; set; }
                /// <summary>
                /// 红包推广短链接
                /// </summary>
                [JsonProperty ("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 红包推广移动链接
                /// </summary>
                [JsonProperty ("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 红包推广移动短链接
                /// </summary>
                [JsonProperty ("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 红包推广多人团链接
                /// </summary>
                [JsonProperty ("multi_group_url")]
                public string MultiGroupUrl { get; set; }
                /// <summary>
                /// 红包推广多人团短链接
                /// </summary>
                [JsonProperty ("multi_group_short_url")]
                public string MultiGroupShortUrl { get; set; }
                /// <summary>
                /// 红包推广多人团移动链接
                /// </summary>
                [JsonProperty ("multi_group_mobile_url")]
                public string MultiGroupMobileUrl { get; set; }
                /// <summary>
                /// 红包推广多人团移动短链接
                /// </summary>
                [JsonProperty ("multi_group_mobile_short_url")]
                public string MultiGroupMobileShortUrl { get; set; }

            }

        }

    }

}