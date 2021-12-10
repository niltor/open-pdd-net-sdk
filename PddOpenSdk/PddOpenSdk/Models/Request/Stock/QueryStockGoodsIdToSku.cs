namespace PddOpenSdk.Models.Request.Stock;
public partial class QueryStockGoodsIdToSku
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 是否需要查询下架商品和sku，默认不需要
    /// </summary>
    [JsonPropertyName("need_offsale")]
    public bool? NeedOffsale { get; set; }

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("ware_id")]
    public long? WareId { get; set; }

}

