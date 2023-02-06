namespace PddOpenSdk.Models.Request.Ad;
public partial class QueryAdApiReportTrHourlyReport
{

    /// <summary>
    /// 查询日期的字符串，格式类似'2020-02-02',当前支持查询30天内数据
    /// </summary>
    [JsonPropertyName("dateString")]
    public string DateString { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

}

