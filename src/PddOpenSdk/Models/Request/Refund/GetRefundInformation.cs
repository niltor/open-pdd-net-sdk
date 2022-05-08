namespace PddOpenSdk.Models.Request.Refund;
public partial class GetRefundInformation
{

    /// <summary>
    /// 售后单id
    /// </summary>
    [JsonPropertyName("after_sales_id")]
    public long? AfterSalesId { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

