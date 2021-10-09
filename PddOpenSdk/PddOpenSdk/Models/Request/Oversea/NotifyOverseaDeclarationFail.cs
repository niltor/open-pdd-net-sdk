namespace PddOpenSdk.Models.Request.Oversea;
public partial class NotifyOverseaDeclarationFail
{

    /// <summary>
    /// 1-超过购买额度，2-清关异常（如重量超标、退运、扣留等）
    /// </summary>
    [JsonPropertyName("fail_reason")]
    public int FailReason { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

