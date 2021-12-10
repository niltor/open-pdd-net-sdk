namespace PddOpenSdk.Models.Request.Promotion;
public partial class CancelPromotionLimitedActivity
{

    /// <summary>
    /// 活动id
    /// </summary>
    [JsonPropertyName("detail_id")]
    public long DetailId { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

}

