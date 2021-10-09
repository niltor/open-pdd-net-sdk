namespace PddOpenSdk.Models.Request.Ad;
public partial class UpdateAdApiUnitBid
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 更新列表
    /// </summary>
    [JsonPropertyName("adUnitBids")]
    public List<AdUnitBidsModel> AdUnitBids { get; set; }

    /// <summary>
    /// 出价资源类型。1表示人群定向，2表示资源位。
    /// </summary>
    [JsonPropertyName("bidReferenceType")]
    public int BidReferenceType { get; set; }
    public partial class AdUnitBidsModel
    {

        /// <summary>
        /// 出价Id
        /// </summary>
        [JsonPropertyName("bidId")]
        public long BidId { get; set; }

        /// <summary>
        /// 出价，万分比
        /// </summary>
        [JsonPropertyName("bidValue")]
        public long BidValue { get; set; }

    }

}

