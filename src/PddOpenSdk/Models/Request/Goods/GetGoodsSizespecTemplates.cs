namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsSizespecTemplates
{

    /// <summary>
    /// 尺码表分类id，pdd.goods.sizespec.class.get得到
    /// </summary>
    [JsonPropertyName("class_id")]
    public long ClassId { get; set; }

    /// <summary>
    /// 限制数量
    /// </summary>
    [JsonPropertyName("limit")]
    public long Limit { get; set; }

    /// <summary>
    /// 偏移量
    /// </summary>
    [JsonPropertyName("offset")]
    public long Offset { get; set; }

}

