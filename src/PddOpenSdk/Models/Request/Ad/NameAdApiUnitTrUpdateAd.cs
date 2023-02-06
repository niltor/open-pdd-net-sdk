namespace PddOpenSdk.Models.Request.Ad;
public partial class NameAdApiUnitTrUpdateAd
{

    /// <summary>
    /// 广告名称
    /// </summary>
    [JsonPropertyName("adName")]
    public string AdName { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

}

