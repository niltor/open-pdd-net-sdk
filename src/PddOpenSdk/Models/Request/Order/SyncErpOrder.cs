namespace PddOpenSdk.Models.Request.Order;
public partial class SyncErpOrder
{

    /// <summary>
    /// 物流公司编码
    /// </summary>
    [JsonPropertyName("logistics_id")]
    public long LogisticsId { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 订单状态：1-已打单
    /// </summary>
    [JsonPropertyName("order_state")]
    public int OrderState { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("waybill_no")]
    public string WaybillNo { get; set; }

}

