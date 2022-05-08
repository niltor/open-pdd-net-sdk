namespace PddOpenSdk.Models.Request.ServiceMarket;
public partial class GetServicemarketTradelist
{

    /// <summary>
    /// 查询起始时间，精确到秒，起止时间间隔最大31天
    /// </summary>
    [JsonPropertyName("begin_time")]
    public int BeginTime { get; set; }

    /// <summary>
    /// 查询结束时间，精确到秒，起止时间间隔最大31天
    /// </summary>
    [JsonPropertyName("end_time")]
    public int EndTime { get; set; }

    /// <summary>
    /// 收支类型，空-全部 1-收入 2-支出
    /// </summary>
    [JsonPropertyName("group_type")]
    public int? GroupType { get; set; }

    /// <summary>
    /// 分页页码，最大1000
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// 分页大小，最大100
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 服务订单号
    /// </summary>
    [JsonPropertyName("service_order_sn")]
    public string ServiceOrderSn { get; set; }

}

