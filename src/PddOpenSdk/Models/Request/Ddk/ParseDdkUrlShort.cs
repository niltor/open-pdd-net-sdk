namespace PddOpenSdk.Models.Request.Ddk;
public partial class ParseDdkUrlShort
{

    /// <summary>
    /// 需要解析出长链的多多进宝短连接，仅支持短链接（即为pdd.ddk.goods.promotion.url.generate接口生成的短链）
    /// </summary>
    [JsonPropertyName("original_url")]
    public string OriginalUrl { get; set; }

}

