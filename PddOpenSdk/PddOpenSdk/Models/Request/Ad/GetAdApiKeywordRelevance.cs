namespace PddOpenSdk.Models.Request.Ad;
public partial class GetAdApiKeywordRelevance
{

    /// <summary>
    /// 商品Id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 关键词数组
    /// </summary>
    [JsonPropertyName("words")]
    public List<string> Words { get; set; }

}

