namespace PddOpenSdk.Models.Response.Ddk;
public partial class ParseDdkUrlShortResponse : PddResponseModel
{

    /// <summary>
    /// 普通长链，与短链接功能一致
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

}

