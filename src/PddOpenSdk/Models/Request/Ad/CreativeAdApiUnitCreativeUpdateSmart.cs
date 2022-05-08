namespace PddOpenSdk.Models.Request.Ad;
public partial class CreativeAdApiUnitCreativeUpdateSmart
{

    /// <summary>
    /// 标题
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// 创意单元Id
    /// </summary>
    [JsonPropertyName("unitCreativeId")]
    public long UnitCreativeId { get; set; }

}

