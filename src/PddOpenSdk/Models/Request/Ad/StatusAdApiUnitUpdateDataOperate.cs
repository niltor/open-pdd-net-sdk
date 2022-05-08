namespace PddOpenSdk.Models.Request.Ad;
public partial class StatusAdApiUnitUpdateDataOperate
{

    /// <summary>
    /// 广告单元Id列表。一次不得超过20个。
    /// </summary>
    [JsonPropertyName("adIds")]
    public List<long> AdIds { get; set; }

    /// <summary>
    /// 数据操作状态。1表示开启，2表示暂停。
    /// </summary>
    [JsonPropertyName("dataOperateStatus")]
    public int DataOperateStatus { get; set; }

}

