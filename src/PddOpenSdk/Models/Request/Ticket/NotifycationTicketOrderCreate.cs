namespace PddOpenSdk.Models.Request.Ticket;
public partial class NotifycationTicketOrderCreate
{

    /// <summary>
    /// 码类型。status=2时必填。1.无凭证(身份证/手机号) 2. 数字码 3.QR图片 4.外链
    /// </summary>
    [JsonPropertyName("code_type")]
    public int? CodeType { get; set; }

    /// <summary>
    /// 失败错误码。status=3时必填
    /// </summary>
    [JsonPropertyName("failed_code")]
    public int? FailedCode { get; set; }

    /// <summary>
    /// 失败原因。 status=3时必填
    /// </summary>
    [JsonPropertyName("failed_reason")]
    public string FailedReason { get; set; }

    /// <summary>
    /// 拼多多制票号
    /// </summary>
    [JsonPropertyName("order_no")]
    public string OrderNo { get; set; }

    /// <summary>
    /// isv订单号
    /// </summary>
    [JsonPropertyName("out_order_sn")]
    public string OutOrderSn { get; set; }

    /// <summary>
    /// 制码状态。 2.制作成功 3.制作失败
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 凭证信息列表。status=2 且 code_type!=1 时必填
    /// </summary>
    [JsonPropertyName("tickets")]
    public List<TicketsModel> Tickets { get; set; }

    /// <summary>
    /// 凭证类型。status=2时必填。1.一人一码 2.一人多码
    /// </summary>
    [JsonPropertyName("ticket_type")]
    public int? TicketType { get; set; }
    public partial class TicketsModel
    {

        /// <summary>
        /// 辅助凭证，有辅助凭证时返回
        /// </summary>
        [JsonPropertyName("additional")]
        public string Additional { get; set; }

        /// <summary>
        /// 主凭证，code_type=2时返回
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 文件base64流，code_type=3时返回，大小小于800KB
        /// </summary>
        [JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// 外链，code_type=4时返回
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

