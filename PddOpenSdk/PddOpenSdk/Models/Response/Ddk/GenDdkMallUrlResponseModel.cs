using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class DdkMallListUrlList
    {

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/PVdl0A"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/app.html?launch_url=duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/PVdl0B"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/PVdl0C"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }
    }

    public class MallCouponGenerateUrlResponse
    {

        /// <summary>
        /// Examples: [{"url":"http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2","short_url":"http://apiv2.hutaojie.com/api/d/PVdl0A","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2","mobile_short_url":"http://apiv2.hutaojie.com/api/d/PVdl0B","we_app_web_view_url":"http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/PVdl0C"}]
        /// </summary>
        [JsonProperty("list")]
        public IList<DdkMallListUrlList> List { get; set; }
    }

    public class GenDdkMallUrlResponseModel
    {

        /// <summary>
        /// Examples: {"list":[{"url":"http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2","short_url":"http://apiv2.hutaojie.com/api/d/PVdl0A","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2","mobile_short_url":"http://apiv2.hutaojie.com/api/d/PVdl0B","we_app_web_view_url":"http://m.hutaojie.com/duo_mall_coupon.html?mall_id=7606022&pid=210035_735&cpsSign=CC210035_735_12b26d652b895c8ae77a8a0b7553919b&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/PVdl0C"}]}
        /// </summary>
        [JsonProperty("mall_coupon_generate_url_response")]
        public MallCouponGenerateUrlResponse MallCouponGenerateUrlResponse { get; set; }
    }


}
