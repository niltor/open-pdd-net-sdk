namespace PddOpenSdk.Models.Response.Voucher;
public partial class SyncVoucherRealtimeVerifyResponse : PddResponseModel
{

    /// <summary>
    /// 错误码
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// 错误描述
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

}

