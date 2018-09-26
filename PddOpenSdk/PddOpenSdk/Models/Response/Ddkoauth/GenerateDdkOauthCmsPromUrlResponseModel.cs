using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class UrlList
    {

        /// <summary>
        /// Examples: "http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=2&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nzErgA"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D2%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nzErgB"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=3&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nzErgC"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D3%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D"
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nzErgD"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }
    }

    public class CmsPromotionUrlGenerateResponse
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"url":"http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=2&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D","short_url":"http://apiv2.hutaojie.com/api/d/nzErgA","mobile_url":"https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D2%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/nzErgB","multi_group_url":"http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=3&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/nzErgC","multi_group_mobile_url":"https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D3%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/nzErgD"}]
        /// </summary>
        [JsonProperty("url_list")]
        public IList<UrlList> UrlList { get; set; }
    }

    public class GenerateDdkOauthCmsPromUrlResponseModel
    {

        /// <summary>
        /// Examples: {"total":1,"url_list":[{"url":"http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=2&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D","short_url":"http://apiv2.hutaojie.com/api/d/nzErgA","mobile_url":"https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D2%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/nzErgB","multi_group_url":"http://m.moremorepin.com/index.html?pid=60005_612&duoduo_type=3&authDuoId=60005&sign=_LU9QoQ3pOX3DSeYl_XhNQ%3D%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/nzErgC","multi_group_mobile_url":"https://m.hutaojie.com/app.html?launch_url=index.html%3Fpid%3D60005_612%26duoduo_type%3D3%26authDuoId%3D60005%26sign%3D_LU9QoQ3pOX3DSeYl_XhNQ%253D%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/nzErgD"}]}
        /// </summary>
        [JsonProperty("cms_promotion_url_generate_response")]
        public CmsPromotionUrlGenerateResponse CmsPromotionUrlGenerateResponse { get; set; }
    }


}
