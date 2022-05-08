namespace PddOpenSdk.Models.Request.Ad;
public partial class StatusAdApiUnitCreativeUpdateDataOperate
{

    /// <summary>
    /// 数据操作状态。1表示开启，2表示暂停。
    /// </summary>
    [JsonPropertyName("dataOperateStatus")]
    public int DataOperateStatus { get; set; }

    /// <summary>
    /// 创意单元Id列表
    /// </summary>
    [JsonPropertyName("unitCreativeIds")]
    public List<long> UnitCreativeIds { get; set; }

}

