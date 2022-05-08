namespace PddOpenSdk.Models.Request.Ad;
public partial class DeleteAdApiKeyword
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 关键词Id列表
    /// </summary>
    [JsonPropertyName("keywordIds")]
    public List<long> KeywordIds { get; set; }

}

