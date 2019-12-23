using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mallticket
{
    public partial class NotifyMallTicketRequestModel : PddRequestModel
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 是否同步给消费者(消费者投诉才有效)
        /// </summary>
        [JsonProperty("syn_to_user")]
        public bool? SynToUser { get; set; }
        /// <summary>
        /// 工单编号
        /// </summary>
        [JsonProperty("ticket_id")]
        public string TicketId { get; set; }

    }

}
