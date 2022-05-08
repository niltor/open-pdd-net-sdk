namespace PddOpenSdk.Models.Request.Ad;
public partial class ProfileAdApiUnitBidQueryBaseTarget
{

    /// <summary>
    /// 商品Id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 场景类型，0-搜索，2-展示
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

}

