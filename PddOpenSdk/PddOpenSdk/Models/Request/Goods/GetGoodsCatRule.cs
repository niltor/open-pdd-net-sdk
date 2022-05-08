namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsCatRule
{

    /// <summary>
    /// 类目id
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

    /// <summary>
    /// 商品id，编辑的时候需要传被编辑的商品id，发布商品时如果已有商品id也需要传
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long? GoodsId { get; set; }

}

