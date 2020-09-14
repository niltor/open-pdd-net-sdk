using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ticket
{
    public partial class NotifycationTicketOrderRefundRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多制票号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 退款金额（分） status=2时必传
        /// </summary>
        [JsonProperty("refund_amount")]
        public long? RefundAmount { get; set; }
        /// <summary>
        /// 驳回原因 status=3时必传
        /// </summary>
        [JsonProperty("reject_reason")]
        public string RejectReason { get; set; }
        /// <summary>
        /// 退款流水号
        /// </summary>
        [JsonProperty("serial_no")]
        public string SerialNo { get; set; }
        /// <summary>
        /// 受理状态。2.已通过 3.已驳回
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

    }

}
