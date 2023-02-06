namespace PddOpenSdk.Models.Request.Ad;
public partial class QueryAdApiReportTrDailyReport
{

    /// <summary>
    /// 结束日期的字符串，格式类似'2020-02-02'
    /// </summary>
    [JsonPropertyName("endDateString")]
    public string EndDateString { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 开始日期的字符串，格式类似'2020-02-02'，如果查询今日，startDateString和endDateString传今日的字符串，如果查询历史，startDateString和endDateString分别传开始和结束字符串，不能跨今日和历史查询,,当前支持查询90天内数据
    /// </summary>
    [JsonPropertyName("startDateString")]
    public string StartDateString { get; set; }

}

