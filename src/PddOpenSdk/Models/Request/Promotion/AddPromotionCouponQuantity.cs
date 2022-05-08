namespace PddOpenSdk.Models.Request.Promotion;
public partial class AddPromotionCouponQuantity
{

    /// <summary>
    /// 券批次ID
    /// </summary>
    [JsonPropertyName("batch_id")]
    public long BatchId { get; set; }

    /// <summary>
    /// 要增加的数量
    /// </summary>
    [JsonPropertyName("add_quantity")]
    public long AddQuantity { get; set; }

}

