namespace PddOpenSdk.Models.Response.OpenMsg;
public partial class MsgOpenMsgServiceSendExpressResponse : PddResponseModel
{

    /// <summary>
    /// 回执id
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string BizId { get; set; }

    /// <summary>
    /// 状态码
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// 状态原因
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

}

