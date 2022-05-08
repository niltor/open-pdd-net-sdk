namespace PddOpenSdk.Models.Request.Ad;
public partial class StatusAdApiPlanUpdateDataOperate
{

    /// <summary>
    /// 数据操作状态。1表示开启，2表示暂停。
    /// </summary>
    [JsonPropertyName("dataOperateStatus")]
    public int DataOperateStatus { get; set; }

    /// <summary>
    /// 广告计划Id列表
    /// </summary>
    [JsonPropertyName("planIds")]
    public List<long> PlanIds { get; set; }

    /// <summary>
    /// 场景类型。0表示搜索，2表示展示。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }

}

