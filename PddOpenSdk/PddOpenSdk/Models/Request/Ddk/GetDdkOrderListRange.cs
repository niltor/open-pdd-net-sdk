namespace PddOpenSdk.Models.Request.Ddk;
public partial class GetDdkOrderListRange
{

    /// <summary>
    /// 是否为礼金订单，查询礼金订单时，订单类型不填（默认推广订单）。
    /// </summary>
    [JsonPropertyName("cash_gift_order")]
    public bool? CashGiftOrder { get; set; }

    /// <summary>
    /// 支付结束时间，格式: "yyyy-MM-dd HH:mm:ss" ，比如 "2020-12-01 00:00:00"
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; }

    /// <summary>
    /// 上一次的迭代器id(第一次不填)
    /// </summary>
    [JsonPropertyName("last_order_id")]
    public string LastOrderId { get; set; }

    /// <summary>
    /// 每次请求多少条，建议300
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 订单类型：1-推广订单；2-直播间订单
    /// </summary>
    [JsonPropertyName("query_order_type")]
    public int? QueryOrderType { get; set; }

    /// <summary>
    /// 支付起始时间，格式: "yyyy-MM-dd HH:mm:ss" ，比如 "2020-12-01 00:00:00"
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; }

}

