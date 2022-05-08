namespace PddOpenSdk.Models.Request.Ad;
public partial class RateAdApiUnitCreativeDistributeFlow
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 流量分配比例。万分比
    /// </summary>
    [JsonPropertyName("creativeFlowRate")]
    public int CreativeFlowRate { get; set; }

}

