namespace PddOpenSdk.Models.Request.Goods;
public partial class CheckGoodsPrice
{

    /// <summary>
    /// 商品id，long值，大于0
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

}

