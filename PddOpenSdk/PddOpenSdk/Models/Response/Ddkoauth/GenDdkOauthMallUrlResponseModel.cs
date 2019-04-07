using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public partial class GenDdkOauthMallUrlResponseModel : PddResponseModel {
        /// <summary>
        /// mall_coupon_generate_url_response
        /// </summary>
        [JsonProperty ("mall_coupon_generate_url_response")]
        public MallCouponGenerateUrlResponseResponseModel MallCouponGenerateUrlResponse { get; set; }
        public partial class MallCouponGenerateUrlResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 推广链接
            /// </summary>
            [JsonProperty ("list")]
            public List<ListResponseModel> List { get; set; }
            public partial class ListResponseModel : PddResponseModel {
                /// <summary>
                /// 推广长链接
                /// </summary>
                [JsonProperty ("url")]
                public string Url { get; set; }
                /// <summary>
                /// 推广短链接
                /// </summary>
                [JsonProperty ("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 唤醒拼多多app的推广长链接
                /// </summary>
                [JsonProperty ("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 唤醒拼多多app的推广短链接
                /// </summary>
                [JsonProperty ("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 唤起微信app推广链接
                /// </summary>
                [JsonProperty ("we_app_web_view_url")]
                public string WeAppWebViewUrl { get; set; }
                /// <summary>
                /// 唤起微信app推广短链接
                /// </summary>
                [JsonProperty ("we_app_web_view_short_url")]
                public string WeAppWebViewShortUrl { get; set; }

            }

        }

    }

}