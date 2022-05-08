namespace PddOpenSdk.Models.Request.Ddk;
public partial class QueryDdkCashgiftData
{

    /// <summary>
    /// 礼金ID，支持根据礼金ID查询
    /// </summary>
    [JsonPropertyName("cash_gift_id")]
    public long? CashGiftId { get; set; }

    /// <summary>
    /// 礼金创建结束时间，查询该时间段内创建的所有礼金效果数据（礼金维度）。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("end_time")]
    public long? EndTime { get; set; }

    /// <summary>
    /// 分页数
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 每页结果数
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 礼金创建起始时间，查询该时间段内创建的所有礼金效果数据（礼金维度）。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("start_time")]
    public long? StartTime { get; set; }

}

