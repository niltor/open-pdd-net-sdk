namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsOuterCatMapping
{

    /// <summary>
    /// 外部叶子类目id
    /// </summary>
    [JsonPropertyName("outer_cat_id")]
    public long OuterCatId { get; set; }

    /// <summary>
    /// 外部叶子类目名称
    /// </summary>
    [JsonPropertyName("outer_cat_name")]
    public string OuterCatName { get; set; }

    /// <summary>
    /// 外部商品名称
    /// </summary>
    [JsonPropertyName("outer_goods_name")]
    public string OuterGoodsName { get; set; }

}

