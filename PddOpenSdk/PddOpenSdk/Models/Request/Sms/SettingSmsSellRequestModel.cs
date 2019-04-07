using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class SettingSmsSellRequestModel : PddRequestModel {
        /// <summary>
        /// 4-新客转化 5-老客转回 6-流失唤醒 8-个性化营销
        /// </summary>
        [JsonProperty ("scene")]
        public int Scene { get; set; }
        /// <summary>
        /// 人群id，个性化营销短信必填
        /// </summary>
        [JsonProperty ("crowd_id")]
        public long? CrowdId { get; set; }
        /// <summary>
        /// 发送时间 必填
        /// </summary>
        [JsonProperty ("send_time")]
        public string SendTime { get; set; }
        /// <summary>
        /// 短信模板id
        /// </summary>
        [JsonProperty ("template_id")]
        public int TemplateId { get; set; }
        /// <summary>
        /// 短信模版类型， 1-官方模版，2-自定义模版
        /// </summary>
        [JsonProperty ("template_type")]
        public int TemplateType { get; set; }

    }

}