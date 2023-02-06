namespace PddOpenSdk.Models.Request.Logistics;
public partial class SendLogisticsFulfillment
{

    /// <summary>
    /// 发货单号
    /// </summary>
    [JsonPropertyName("fulfillment_sn")]
    public string FulfillmentSn { get; set; }

    /// <summary>
    /// 快递公司编号
    /// </summary>
    [JsonPropertyName("logistics_id")]
    public int LogisticsId { get; set; }

    /// <summary>
    /// 枚举：1=首次发货：用于托管发货单首次发货，仅待发货托管单可传入； 2=修改发货：用于修改发货，调用成功后将会覆盖原发货信息，仅已发货2小时内的托管发货单可传入。若不传入该字段，系统将默认为首次发货。
    /// </summary>
    [JsonPropertyName("redelivery_type")]
    public int? RedeliveryType { get; set; }

    /// <summary>
    /// 退货地址id（可通过pdd.refund.address.list.get获取）
    /// </summary>
    [JsonPropertyName("return_address_id")]
    public string ReturnAddressId { get; set; }

    /// <summary>
    /// 发货运单号
    /// </summary>
    [JsonPropertyName("tracking_number")]
    public string TrackingNumber { get; set; }

}

