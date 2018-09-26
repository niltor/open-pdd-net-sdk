using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class GoodsZsUnitGenerateResponse
    {

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=2108082347&pid=1000098_16621136&t=1531059063033&sign=y-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%3D&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/75pKRc"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html%3Fgoods_id%3D2108082347%26pid%3D1000098_16621136%26t%3D1531059063033%26sign%3Dy-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%253D%26duoduo_type%3D2"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/75pKsv"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=2108082347&pid=1000098_16621136&t=1531059063033&sign=y-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%3D&duoduo_type=3"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/75pJgf"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html%3Fgoods_id%3D2108082347%26pid%3D1000098_16621136%26t%3D1531059063033%26sign%3Dy-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%253D%26duoduo_type%3D3"
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/75pJgd"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }
    }

    public class GenDdkOauthGoodsZsUnitUrlResponseModel
    {

        /// <summary>
        /// Examples: {"url":"https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=2108082347&pid=1000098_16621136&t=1531059063033&sign=y-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%3D&duoduo_type=2","short_url":"https://a.toutiaonanren.com/api/d/75pKRc","mobile_url":"https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html%3Fgoods_id%3D2108082347%26pid%3D1000098_16621136%26t%3D1531059063033%26sign%3Dy-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%253D%26duoduo_type%3D2","mobile_short_url":"https://a.toutiaonanren.com/api/d/75pKsv","multi_group_url":"https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=2108082347&pid=1000098_16621136&t=1531059063033&sign=y-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%3D&duoduo_type=3","multi_group_short_url":"https://a.toutiaonanren.com/api/d/75pJgf","multi_group_mobile_url":"https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html%3Fgoods_id%3D2108082347%26pid%3D1000098_16621136%26t%3D1531059063033%26sign%3Dy-uhUioAltzlMYb-Nbir6ehC9Gjyx5gdHhs1g6jYJhY%253D%26duoduo_type%3D3","multi_group_mobile_short_url":"https://a.toutiaonanren.com/api/d/75pJgd"}
        /// </summary>
        [JsonProperty("goods_zs_unit_generate_response")]
        public GoodsZsUnitGenerateResponse GoodsZsUnitGenerateResponse { get; set; }
    }


}
