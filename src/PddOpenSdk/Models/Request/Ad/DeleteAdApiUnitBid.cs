namespace PddOpenSdk.Models.Request.Ad;
public partial class DeleteAdApiUnitBid
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 出价Id列表
    /// </summary>
    [JsonPropertyName("bidIds")]
    public List<long> BidIds { get; set; }

}

