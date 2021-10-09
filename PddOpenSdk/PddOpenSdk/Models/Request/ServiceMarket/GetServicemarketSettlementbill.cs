namespace PddOpenSdk.Models.Request.ServiceMarket;
public partial class GetServicemarketSettlementbill
{

    /// <summary>
    /// 分页页码，最大不能超过1000
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// 分页大小，最大不能超过100
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 服务订单号
    /// </summary>
    [JsonPropertyName("service_order_sn")]
    public string ServiceOrderSn { get; set; }

    /// <summary>
    /// 结算月份
    /// </summary>
    [JsonPropertyName("settle_month")]
    public string SettleMonth { get; set; }

}

