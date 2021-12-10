namespace PddOpenSdk.Models.Request.Goods;
public partial class SetGoodsSaleStatus
{

    /// <summary>
    /// 拼多多商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 上下架状态：1:上架 0:下架
    /// </summary>
    [JsonPropertyName("is_onsale")]
    public int IsOnsale { get; set; }

}

