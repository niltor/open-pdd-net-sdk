namespace PddOpenSdk.Models.Request.Order;
public partial class GetOrderInformation
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

