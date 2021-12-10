namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsList
{

    /// <summary>
    /// 商品外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name
    /// </summary>
    [JsonPropertyName("outer_id")]
    public string OuterId { get; set; }

    /// <summary>
    /// 上下架状态，0-下架，1-上架,outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name
    /// </summary>
    [JsonPropertyName("is_onsale")]
    public int? IsOnsale { get; set; }

    /// <summary>
    /// 商品名称模糊查询,outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name
    /// </summary>
    [JsonPropertyName("goods_name")]
    public string GoodsName { get; set; }

    /// <summary>
    /// 返回数量，默认 100，最大100。
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 返回页码 默认 1，页码从 1 开始PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 商家外部商品编码，支持多个，用逗号隔开，最多10个
    /// </summary>
    [JsonPropertyName("outer_goods_id")]
    public string OuterGoodsId { get; set; }

    /// <summary>
    /// 模版id
    /// </summary>
    [JsonPropertyName("cost_template_id")]
    public long? CostTemplateId { get; set; }

}

