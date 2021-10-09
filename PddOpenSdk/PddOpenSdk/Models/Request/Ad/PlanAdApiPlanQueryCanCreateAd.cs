namespace PddOpenSdk.Models.Request.Ad;
public partial class PlanAdApiPlanQueryCanCreateAd
{

    /// <summary>
    /// 单元名称
    /// </summary>
    [JsonPropertyName("planName")]
    public string PlanName { get; set; }

    /// <summary>
    /// 场景类型。0表示搜索，2表示展示。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

}

