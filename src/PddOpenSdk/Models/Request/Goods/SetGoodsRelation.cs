namespace PddOpenSdk.Models.Request.Goods;
public partial class SetGoodsRelation
{

    /// <summary>
    /// 拼多多商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 月销量
    /// </summary>
    [JsonPropertyName("month_sales")]
    public long? MonthSales { get; set; }

    /// <summary>
    /// 外部平台商品url
    /// </summary>
    [JsonPropertyName("out_detail_url")]
    public string OutDetailUrl { get; set; }

    /// <summary>
    /// 外部平台商品id
    /// </summary>
    [JsonPropertyName("out_goods_id")]
    public string OutGoodsId { get; set; }

    /// <summary>
    /// 外部平台商品最高价，单位：分
    /// </summary>
    [JsonPropertyName("out_high_goods_price")]
    public long OutHighGoodsPrice { get; set; }

    /// <summary>
    /// 外部平台商品最低价，单位：分
    /// </summary>
    [JsonPropertyName("out_low_goods_price")]
    public long OutLowGoodsPrice { get; set; }

    /// <summary>
    /// 外部平台店铺id
    /// </summary>
    [JsonPropertyName("out_mall_id")]
    public long? OutMallId { get; set; }

    /// <summary>
    /// 邮费
    /// </summary>
    [JsonPropertyName("postage")]
    public long Postage { get; set; }

}

