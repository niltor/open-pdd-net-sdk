namespace PddOpenSdk.Models.Request.Order;
public partial class GetOrderStatus
{

    /// <summary>
    /// 20150909-452750051,20150909-452750134 用逗号分开
    /// </summary>
    [JsonPropertyName("order_sns")]
    public string OrderSns { get; set; }

}

