namespace PddOpenSdk.Models.Request.Goods;
public partial class SearchGoodsTemplatePropertyValue
{

    /// <summary>
    /// 类目id
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

    /// <summary>
    /// 页码 从1开始
    /// </summary>
    [JsonPropertyName("page_num")]
    public int? PageNum { get; set; }

    /// <summary>
    /// 1页查询的最大数据 [1，500], 默认100
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 父属性值id
    /// </summary>
    [JsonPropertyName("parent_vid")]
    public long? ParentVid { get; set; }

    /// <summary>
    /// 模板属性id，废弃中，请入参属性id
    /// </summary>
    [JsonPropertyName("template_pid")]
    public long? TemplatePid { get; set; }

    /// <summary>
    /// 需要模糊搜索的属性值
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// 属性id
    /// </summary>
    [JsonPropertyName("ref_pid")]
    public long? RefPid { get; set; }

}

