namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsSkus
{

    /// <summary>
    /// 商品Id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// sku id
    /// </summary>
    [JsonPropertyName("sku_id")]
    public long SkuId { get; set; }

}

