namespace PddOpenSdk.Models.Request.Goods;
public partial class QueryGoodsMaterial
{

    /// <summary>
    /// 商品id列表
    /// </summary>
    [JsonPropertyName("goods_id_list")]
    public List<long> GoodsIdList { get; set; }

    /// <summary>
    /// 素材类型列表
    /// </summary>
    [JsonPropertyName("type_list")]
    public List<long> TypeList { get; set; }

}

