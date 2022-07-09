namespace PddOpenSdk.Models.Request.Ad;
public partial class QueryAdApiReportActivityReport
{

    /// <summary>
    /// 结束日期的字符串，格式类似'2020-02-02'
    /// </summary>
    [JsonPropertyName("endDateString")]
    public string EndDateString { get; set; }

    /// <summary>
    /// 场景类型：3联合推广。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

    /// <summary>
    /// 开始日期的字符串，格式类似'2020-02-02'，如果查询今日，startDateString和endDateString传今日的字符串，如果查询历史，startDateString和endDateString分别传开始和结束字符串，不能跨今日和历史查询
    /// </summary>
    [JsonPropertyName("startDateString")]
    public string StartDateString { get; set; }

}

