using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class SettingSmsCustomRequestModel : PddRequestModel
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }
        /// <summary>
        /// 待发送手机号，["15671551276"]
        /// </summary>
        [JsonProperty("phones")]
        public int Phones { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        [JsonProperty("send_time")]
        public string SendTime { get; set; }
        /// <summary>
        /// //短信模版类型， 1-官方模版，2-自定义模版
        /// </summary>
        [JsonProperty("template_type")]
        public int TemplateType { get; set; }

    }
}
