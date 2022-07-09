namespace PddOpenSdk.Models.Request.Util;
public partial class ReportPopMallBindRelation
{

    /// <summary>
    /// 关联时间
    /// </summary>
    [JsonPropertyName("bind_at")]
    public long BindAt { get; set; }

    /// <summary>
    /// 关联类型：0-关联码关联，1-授权关联
    /// </summary>
    [JsonPropertyName("bind_type")]
    public int BindType { get; set; }

    /// <summary>
    /// 三方应用的用户id
    /// </summary>
    [JsonPropertyName("external_uid")]
    public string ExternalUid { get; set; }

    /// <summary>
    /// 被关联方的店铺id
    /// </summary>
    [JsonPropertyName("invitee_mall_id")]
    public long InviteeMallId { get; set; }

    /// <summary>
    /// 发起关联方的店铺id
    /// </summary>
    [JsonPropertyName("inviter_mall_id")]
    public long InviterMallId { get; set; }

    /// <summary>
    /// 当前店群包含的拼多多店铺id
    /// </summary>
    [JsonPropertyName("mall_list")]
    public List<long?> MallList { get; set; }

}

