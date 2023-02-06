namespace PddOpenSdk.Models.Request.Goods;
public partial class RelationGoodsGet
{

    /// <summary>
    /// 拼多多商品id
    /// </summary>
    [JsonPropertyName("pdd_goods_id")]
    public List<long> PddGoodsId { get; set; }

}

