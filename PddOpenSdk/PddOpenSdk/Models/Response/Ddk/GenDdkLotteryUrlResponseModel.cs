using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class SingleUrlList
    {

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZm"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mobile_url")]
        public object MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZn"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZo"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// Examples: "?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"
        /// </summary>
        [JsonProperty("we_app_page_path")]
        public string WeAppPagePath { get; set; }
    }

    public class UrlList
    {

        /// <summary>
        /// Examples: {"url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","short_url":"http://.../api/d/RqvnZm","mobile_url":null,"mobile_short_url":"http://.../api/d/RqvnZn","we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/RqvnZo","we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"}
        /// </summary>
        [JsonProperty("single_url_list")]
        public SingleUrlList SingleUrlList { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("multi_url_list")]
        public object MultiUrlList { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZm"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mobile_url")]
        public object MobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZn"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1"
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZo"
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// Examples: "?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"
        /// </summary>
        [JsonProperty("we_app_page_path")]
        public string WeAppPagePath { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZp"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public object MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZq"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3&launch_wx=1"
        /// </summary>
        [JsonProperty("multi_we_app_web_view_url")]
        public string MultiWeAppWebViewUrl { get; set; }

        /// <summary>
        /// Examples: "http://.../api/d/RqvnZq"
        /// </summary>
        [JsonProperty("multi_we_app_web_view_short_url")]
        public string MultiWeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// Examples: "?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3"
        /// </summary>
        [JsonProperty("multi_we_app_page_path")]
        public string MultiWeAppPagePath { get; set; }

        /// <summary>
        /// Examples: "CL210035_2760_ab446fc36b7858e903b40146438f8d49"
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("we_app_info")]
        public object WeAppInfo { get; set; }
    }

    public class LotteryUrlResponse
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"single_url_list":{"url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","short_url":"http://.../api/d/RqvnZm","mobile_url":null,"mobile_short_url":"http://.../api/d/RqvnZn","we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/RqvnZo","we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"},"multi_url_list":null,"url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","short_url":"http://.../api/d/RqvnZm","mobile_url":null,"mobile_short_url":"http://.../api/d/RqvnZn","we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/RqvnZo","we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","multi_group_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3","multi_group_short_url":"http://.../api/d/RqvnZp","multi_group_mobile_url":null,"multi_group_mobile_short_url":"http://.../api/d/RqvnZq","multi_we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3&launch_wx=1","multi_we_app_web_view_short_url":"http://.../api/d/RqvnZq","multi_we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3","sign":"CL210035_2760_ab446fc36b7858e903b40146438f8d49","we_app_info":null}]
        /// </summary>
        [JsonProperty("url_list")]
        public IList<UrlList> UrlList { get; set; }
    }

    public class GenDdkLotteryUrlResponseModel
    {

        /// <summary>
        /// Examples: {"total":1,"url_list":[{"single_url_list":{"url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","short_url":"http://.../api/d/RqvnZm","mobile_url":null,"mobile_short_url":"http://.../api/d/RqvnZn","we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/RqvnZo","we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2"},"multi_url_list":null,"url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","short_url":"http://.../api/d/RqvnZm","mobile_url":null,"mobile_short_url":"http://.../api/d/RqvnZn","we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2&launch_wx=1","we_app_web_view_short_url":"http://.../api/d/RqvnZo","we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=2","multi_group_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3","multi_group_short_url":"http://.../api/d/RqvnZp","multi_group_mobile_url":null,"multi_group_mobile_short_url":"http://.../api/d/RqvnZq","multi_we_app_web_view_url":"http://.../duo_roulette.html?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3&launch_wx=1","multi_we_app_web_view_short_url":"http://.../api/d/RqvnZq","multi_we_app_page_path":"?pid=210035_2760&cpsSign=CL210035_2760_ab446fc36b7858e903b40146438f8d48&duoduo_type=3","sign":"CL210035_2760_ab446fc36b7858e903b40146438f8d49","we_app_info":null}]}
        /// </summary>
        [JsonProperty("lottery_url_response")]
        public LotteryUrlResponse LotteryUrlResponse { get; set; }
    }


}
