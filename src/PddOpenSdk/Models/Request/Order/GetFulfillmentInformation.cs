namespace PddOpenSdk.Models.Request.Order;
public partial class GetFulfillmentInformation
{

    /// <summary>
    /// 跨境全托管发货单号
    /// </summary>
    [JsonPropertyName("fulfillment_sn")]
    public string FulfillmentSn { get; set; }

}

