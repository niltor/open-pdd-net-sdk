using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class UrlList
    {

        /// <summary>
        /// Examples: "https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=2&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nmEzjq"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D2%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nmEzjr"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=3&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nmEzjs"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D3%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D"
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/nmEzjt"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }
    }

    public class RpPromotionUrlGenerateResponse
    {

        /// <summary>
        /// Examples: [{"url":"https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=2&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D","short_url":"http://apiv2.hutaojie.com/api/d/nmEzjq","mobile_url":"https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D2%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjr","multi_group_url":"https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=3&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjs","multi_group_mobile_url":"https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D3%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjt"}]
        /// </summary>
        [JsonProperty("url_list")]
        public IList<UrlList> UrlList { get; set; }
    }

    public class GenerateDdkOauthRpPromUrlResponseModel
    {

        /// <summary>
        /// Examples: {"url_list":[{"url":"https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=2&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D","short_url":"http://apiv2.hutaojie.com/api/d/nmEzjq","mobile_url":"https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D2%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjr","multi_group_url":"https://m.hutaojie.com/duo_red_packet.html?pid=60005_612&duoduo_type=3&sign=kRt7Ka4ENaHDDp8PFGwNSw%3D%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjs","multi_group_mobile_url":"https://m.hutaojie.com/app.html?launch_url=duo_red_packet.html%3Fpid%3D60005_612%26duoduo_type%3D3%26sign%3DkRt7Ka4ENaHDDp8PFGwNSw%253D%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/nmEzjt"}]}
        /// </summary>
        [JsonProperty("rp_promotion_url_generate_response")]
        public RpPromotionUrlGenerateResponse RpPromotionUrlGenerateResponse { get; set; }
    }


}
