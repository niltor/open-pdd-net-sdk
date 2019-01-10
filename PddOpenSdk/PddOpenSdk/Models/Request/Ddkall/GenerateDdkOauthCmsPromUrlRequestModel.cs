using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddkall
{
    public partial class GenerateDdkOauthCmsPromUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("p_id_list")]
        public List<string> PIdList { get; set; }
        /// <summary>
        /// 是否生成手机跳转链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_mobile")]
        public bool? GenerateMobile { get; set; }
        /// <summary>
        /// 单人团多人团标志。true-多人团，false-单人团 默认false
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
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
        /// <summary>
        /// 0, "1.9包邮"；1, "今日爆款"； 2, "品牌清仓"； 4,"PC端专属商城"；5，“赚多多币兑现金”；不传值为默认商城；
        /// </summary>
        [JsonProperty("channel_type")]
        public int ChannelType { get; set; }

    }

}
