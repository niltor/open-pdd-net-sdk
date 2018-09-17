using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GenerateDdkThemePromUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为:pdd.ddk.theme.prom.url.generate
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 推广位ID
        /// </summary>
        [JsonProperty("pid")]
        public object Pid { get; set; }
        /// <summary>
        /// 主题ID列表,例如[1,235]
        /// </summary>
        [JsonProperty("theme_id_list")]
        public object ThemeIdList { get; set; }
        /// <summary>
        /// 是否生成短链接,true-是,false-否
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// 是否生成手机跳转链接。true-是,false-否,默认false
        /// </summary>
        [JsonProperty("generate_mobile")]
        public bool? GenerateMobile { get; set; }
        /// <summary>
        /// 自定义参数,为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public object CustomParameters { get; set; }
        /// <summary>
        /// 是否唤起微信客户端， 默认false 否，true 是
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool? GenerateWeappWebview { get; set; }
        /// <summary>
        /// 唤起微信app推广短链接
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public bool? WeAppWebViewShortUrl { get; set; }
        /// <summary>
        /// 唤起微信app推广链接
        /// </summary>
        [JsonProperty("we_app_web_wiew_url")]
        public bool? WeAppWebWiewUrl { get; set; }

    }
}
