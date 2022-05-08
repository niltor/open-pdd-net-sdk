namespace PddOpenSdk.Models.Request.Ddk;
public partial class QueryDdkStatisticsData
{

    /// <summary>
    /// 分页数，默认值: 1
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 每页结果数，默认值: 20
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 周期类型: 1-每7天，2-自然月
    /// </summary>
    [JsonPropertyName("period_type")]
    public int PeriodType { get; set; }

    /// <summary>
    /// 数据类型: 1-增量补贴数据
    /// </summary>
    [JsonPropertyName("statistics_type")]
    public int StatisticsType { get; set; }

    /// <summary>
    /// 查询时间点，格式: "yyyy-MM-dd"。period_type为1时，查询时间点前7天的数据；period_type为2时，查询时间点所在自然月的数据。
    /// </summary>
    [JsonPropertyName("time")]
    public string Time { get; set; }

}

