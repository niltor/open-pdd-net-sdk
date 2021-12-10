namespace PddOpenSdk.Models.Request.Ad;
public partial class BidAdApiUnitUpdateUnit
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 出价不得为空。单位厘。
    /// </summary>
    [JsonPropertyName("bid")]
    public long Bid { get; set; }

}

