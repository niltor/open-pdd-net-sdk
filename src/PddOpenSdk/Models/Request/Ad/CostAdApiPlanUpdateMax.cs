namespace PddOpenSdk.Models.Request.Ad;
public partial class CostAdApiPlanUpdateMax
{

    /// <summary>
    /// 日消耗上限。单位厘。
    /// </summary>
    [JsonPropertyName("maxCost")]
    public long MaxCost { get; set; }

    /// <summary>
    /// 广告计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long PlanId { get; set; }

}

