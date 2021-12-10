namespace PddOpenSdk.Models.Request.Oversea;
public partial class GetOverseaClearance
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

