namespace PddOpenSdk.Models.Request.Ad;
public partial class DeleteAdApiUnit
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 场景类型。0表示搜索，2表示展示。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

}

