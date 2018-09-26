using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class SettingSmsRemainRequestModel : PddRequestModel
    {
        /// <summary>
        /// 买家未付款时间，单位为分钟。例，unpaid_duration=3，买家下单后3分钟未付款，即发送短信提醒买家付款
        /// </summary>
        [JsonProperty("unpaid_duration")]
        public int? UnpaidDuration { get; set; }
        /// <summary>
        /// 指定的短信任务的模板id
        /// </summary>
        [JsonProperty("template_id")]
        public int? TemplateId { get; set; }
        /// <summary>
        /// 该提醒任务是否处于处于打开状态，0-关闭，此时提醒任务被关闭，1-打开，此时提醒任务打开
        /// </summary>
        [JsonProperty("open")]
        public int Open { get; set; }
        /// <summary>
        /// 该任务对应的场景//1-提醒付款 3-召唤买家成团
        /// </summary>
        [JsonProperty("scene")]
        public int Scene { get; set; }
        /// <summary>
        /// operate_type// 1-开启任务   2-编辑
        /// </summary>
        [JsonProperty("operate_type")]
        public int OperateType { get; set; }

    }

}
