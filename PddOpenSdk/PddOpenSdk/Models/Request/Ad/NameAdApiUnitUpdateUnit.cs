namespace PddOpenSdk.Models.Request.Ad;
public partial class NameAdApiUnitUpdateUnit
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 单元名称
    /// </summary>
    [JsonPropertyName("adName")]
    public string AdName { get; set; }

}

