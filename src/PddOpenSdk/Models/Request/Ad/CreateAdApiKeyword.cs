namespace PddOpenSdk.Models.Request.Ad;
public partial class CreateAdApiKeyword
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 关键词创建信息列表
    /// </summary>
    [JsonPropertyName("keywordList")]
    public List<KeywordListModel> KeywordList { get; set; }
    public partial class KeywordListModel
    {

        /// <summary>
        /// 关键词出价
        /// </summary>
        [JsonPropertyName("bid")]
        public long Bid { get; set; }

        /// <summary>
        /// 关键词溢价比例。万分比。
        /// </summary>
        [JsonPropertyName("premiumRate")]
        public long? PremiumRate { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonPropertyName("word")]
        public string Word { get; set; }

    }

}

