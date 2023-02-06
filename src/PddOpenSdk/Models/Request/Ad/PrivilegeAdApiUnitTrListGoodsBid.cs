namespace PddOpenSdk.Models.Request.Ad;
public partial class PrivilegeAdApiUnitTrListGoodsBid
{

    /// <summary>
    /// 商品id列表
    /// </summary>
    [JsonPropertyName("goodsIds")]
    public List<long> GoodsIds { get; set; }

}

