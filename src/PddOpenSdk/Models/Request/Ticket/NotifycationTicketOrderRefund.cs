namespace PddOpenSdk.Models.Request.Ticket;
public partial class NotifycationTicketOrderRefund
{

    /// <summary>
    /// 拼多多制票号
    /// </summary>
    [JsonPropertyName("order_no")]
    public string OrderNo { get; set; }

    /// <summary>
    /// 退款金额（分） status=2时必传
    /// </summary>
    [JsonPropertyName("refund_amount")]
    public long? RefundAmount { get; set; }

    /// <summary>
    /// 驳回原因 status=3时必传
    /// </summary>
    [JsonPropertyName("reject_reason")]
    public string RejectReason { get; set; }

    /// <summary>
    /// 退款流水号
    /// </summary>
    [JsonPropertyName("serial_no")]
    public string SerialNo { get; set; }

    /// <summary>
    /// 受理状态。2.已通过 3.已驳回
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

}

