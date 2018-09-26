using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class UrlList
    {

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=2&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/sVYCbe"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D2%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/sVYCbf"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=3&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/sVYCbg"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D3%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D"
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/sVYCbh"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }
    }

    public class ThemePromotionUrlGenerateResponse
    {

        /// <summary>
        /// Examples: [{"url":"http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=2&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D","short_url":"http://apiv2.hutaojie.com/api/d/sVYCbe","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D2%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbf","multi_group_url":"http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=3&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbg","multi_group_mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D3%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbh"}]
        /// </summary>
        [JsonProperty("url_list")]
        public IList<UrlList> UrlList { get; set; }
    }

    public class GenerateDdkThemePromUrlResponseModel
    {

        /// <summary>
        /// Examples: {"url_list":[{"url":"http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=2&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D","short_url":"http://apiv2.hutaojie.com/api/d/sVYCbe","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D2%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D","mobile_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbf","multi_group_url":"http://m.hutaojie.com/duo_theme_activity.html?themeId=124&pid=210035_947&duoduo_type=3&customParameters=222&sign=B0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%3D","multi_group_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbg","multi_group_mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_theme_activity.html%3FthemeId%3D124%26pid%3D210035_947%26duoduo_type%3D3%26customParameters%3D222%26sign%3DB0bUWJqnQWFD3LVjQGVl2GSknreRU0ruQehkkj2NSlI%253D","multi_group_mobile_short_url":"http://apiv2.hutaojie.com/api/d/sVYCbh"}]}
        /// </summary>
        [JsonProperty("theme_promotion_url_generate_response")]
        public ThemePromotionUrlGenerateResponse ThemePromotionUrlGenerateResponse { get; set; }
    }


}
