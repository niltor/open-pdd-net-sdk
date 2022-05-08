namespace PddOpenSdk.Models.Response.Order;
public partial class SyncErpOrderResponse : PddResponseModel
{

    /// <summary>
    /// 错误代码
    /// </summary>
    [JsonPropertyName("error_code")]
    public long? ErrorCode { get; set; }

    /// <summary>
    /// 错误参数
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string ErrorMsg { get; set; }

    /// <summary>
    /// 是否有结果
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }

    /// <summary>
    /// 是否成功
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}

