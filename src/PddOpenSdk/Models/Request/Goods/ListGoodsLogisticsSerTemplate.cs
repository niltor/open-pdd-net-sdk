namespace PddOpenSdk.Models.Request.Goods;
public partial class ListGoodsLogisticsSerTemplate
{

    /// <summary>
    /// 查询大小
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// 查询类型
    /// </summary>
    [JsonPropertyName("query_type")]
    public int QueryType { get; set; }

    /// <summary>
    /// 查询偏移量
    /// </summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }

    /// <summary>
    /// 模板类型
    /// </summary>
    [JsonPropertyName("template_type")]
    public int TemplateType { get; set; }

}

