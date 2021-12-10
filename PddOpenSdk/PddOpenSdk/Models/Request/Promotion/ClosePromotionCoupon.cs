namespace PddOpenSdk.Models.Request.Promotion;
public partial class ClosePromotionCoupon
{

    /// <summary>
    /// 券批次ID
    /// </summary>
    [JsonPropertyName("batch_id")]
    public long BatchId { get; set; }

}

