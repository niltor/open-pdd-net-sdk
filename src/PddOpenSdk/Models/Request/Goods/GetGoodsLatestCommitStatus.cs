namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsLatestCommitStatus
{

    /// <summary>
    /// 商品id(不超过100个)
    /// </summary>
    [JsonPropertyName("goods_id_list")]
    public List<long> GoodsIdList { get; set; }

}

