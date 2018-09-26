using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class SingleUrlList
    {

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2k"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2l"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2m"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("we_app_page_path")]
        public object WeAppPagePath { get; set; }
    }

    public class MultiUrlList
    {

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2n"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2o"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/XsNS2p"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("we_app_page_path")]
        public object WeAppPagePath { get; set; }
    }

    public class ResourceUrlResponse
    {

        /// <summary>
        /// Examples: {"url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","short_url":"http://apiv2.hutaojie.com/api/d/XsNS2k","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","mobile_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2l","we_app_web_view_url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2m","we_app_page_path":null}
        /// </summary>
        [JsonProperty("single_url_list")]
        public SingleUrlList SingleUrlList { get; set; }

        /// <summary>
        /// Examples: {"url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3","short_url":"http://apiv2.hutaojie.com/api/d/XsNS2n","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3","mobile_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2o","we_app_web_view_url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2p","we_app_page_path":null}
        /// </summary>
        [JsonProperty("multi_url_list")]
        public MultiUrlList MultiUrlList { get; set; }

        /// <summary>
        /// Examples: "CE210035_735_bc9a90f00fb9e0615f694501536302cd"
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }
    }

    public class GenDdkOauthResourceUrlResponseModel
    {

        /// <summary>
        /// Examples: {"single_url_list":{"url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","short_url":"http://apiv2.hutaojie.com/api/d/XsNS2k","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2","mobile_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2l","we_app_web_view_url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2m","we_app_page_path":null},"multi_url_list":{"url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3","short_url":"http://apiv2.hutaojie.com/api/d/XsNS2n","mobile_url":"http://m.hutaojie.com/app.html?launch_url=duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3","mobile_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2o","we_app_web_view_url":"http://m.hutaojie.com/duo_transfer_channel.html?resourceType=null&pid=210035_735&authDuoId=210035&cpsSign=CE210035_735_bc9a90f00fb9e0615f694501536302cd&duoduo_type=3&launch_wx=1","we_app_web_view_short_url":"http://apiv2.hutaojie.com/api/d/XsNS2p","we_app_page_path":null},"sign":"CE210035_735_bc9a90f00fb9e0615f694501536302cd"}
        /// </summary>
        [JsonProperty("resource_url_response")]
        public ResourceUrlResponse ResourceUrlResponse { get; set; }
    }


}
