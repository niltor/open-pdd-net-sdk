namespace PddOpenSdk.Models.Request.Ad;
public partial class UpdateAdApiKeyword
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 关键词列表
    /// </summary>
    [JsonPropertyName("keywords")]
    public List<KeywordsModel> Keywords { get; set; }
    public partial class KeywordsModel
    {

        /// <summary>
        /// 关键词出价
        /// </summary>
        [JsonPropertyName("bid")]
        public long Bid { get; set; }

        /// <summary>
        /// 关键词Id
        /// </summary>
        [JsonPropertyName("keywordId")]
        public long KeywordId { get; set; }

        /// <summary>
        /// 关键词溢价比例。万分比。
        /// </summary>
        [JsonPropertyName("premiumRate")]
        public long? PremiumRate { get; set; }

    }

}

