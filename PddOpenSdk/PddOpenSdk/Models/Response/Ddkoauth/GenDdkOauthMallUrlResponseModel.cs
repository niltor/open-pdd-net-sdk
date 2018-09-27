using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class MallCouponList
    {

        /// <summary>
        /// Examples: "http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/PVhx0k"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../app.html?launch_url=duo_mall_coupon.html?mall_id=7606032&pid=210045_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/PVhx0l"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/PVhx0m"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }
    }

    public class MallCouponGenerateUrlResponse
    {

        /// <summary>
        /// Examples: [{"url":"http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","short_url":"http://.../api/d/PVhx0k","mobile_url":"http://.../app.html?launch_url=duo_mall_coupon.html?mall_id=7606032&pid=210045_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","mobile_short_url":"http://.../api/d/PVhx0l","we_app_web_view_url":"http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/PVhx0m"}]
        /// </summary>
        [JsonProperty("list")]
        public IList<MallCouponList> List { get; set; }
    }

    public class GenDdkOauthMallUrlResponseModel
    {

        /// <summary>
        /// Examples: {"list":[{"url":"http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","short_url":"http://.../api/d/PVhx0k","mobile_url":"http://.../app.html?launch_url=duo_mall_coupon.html?mall_id=7606032&pid=210045_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","mobile_short_url":"http://.../api/d/PVhx0l","we_app_web_view_url":"http://.../duo_mall_coupon.html?mall_id=7606022&pid=210035_735&authDuoId=210035&cpsSign=CC210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/PVhx0m"}]}
        /// </summary>
        [JsonProperty("mall_coupon_generate_url_response")]
        public MallCouponGenerateUrlResponse MallCouponGenerateUrlResponse { get; set; }
    }


}
