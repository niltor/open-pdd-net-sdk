namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsInformation
{

    /// <summary>
    /// 商品编码
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

}

