namespace PddOpenSdk.Models.Request.Invoice;
public partial class InvalidInvoiceDetail
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

