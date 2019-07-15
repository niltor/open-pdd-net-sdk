using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkoauth
{
    public partial class GenDdkOauthResourceUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 推广位
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 频道来源：4-限时秒杀,39997-充值中心, 39998-转链type，39999-电器城
        /// </summary>
        [JsonProperty("resource_type")]
        public int? ResourceType { get; set; }
        /// <summary>
        /// 原链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

    }

}
