namespace PddOpenSdk.Models.Request.Ad;
public partial class NameAdApiPlanUpdatePlan
{

    /// <summary>
    /// 广告计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long PlanId { get; set; }

    /// <summary>
    /// 计划名称
    /// </summary>
    [JsonPropertyName("planName")]
    public string PlanName { get; set; }

}

