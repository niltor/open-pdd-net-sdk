namespace PddOpenSdk.Models.Request.Ticket;
public partial class NotifycationTicketVerification
{

    /// <summary>
    /// 拼多多制票号
    /// </summary>
    [JsonPropertyName("order_no")]
    public string OrderNo { get; set; }

    /// <summary>
    /// 核销时间（13位毫秒数）
    /// </summary>
    [JsonPropertyName("verify_time")]
    public long VerifyTime { get; set; }

}

