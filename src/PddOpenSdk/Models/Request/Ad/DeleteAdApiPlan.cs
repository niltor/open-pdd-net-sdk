namespace PddOpenSdk.Models.Request.Ad;
public partial class DeleteAdApiPlan
{

    /// <summary>
    /// 广告计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long PlanId { get; set; }

    /// <summary>
    /// 场景类型，0-搜索，2-展示
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

}

