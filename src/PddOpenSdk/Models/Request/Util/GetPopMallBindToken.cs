namespace PddOpenSdk.Models.Request.Util;
public partial class GetPopMallBindToken
{

    /// <summary>
    /// 被关联店铺的关联code
    /// </summary>
    [JsonPropertyName("bind_code")]
    public string BindCode { get; set; }

    /// <summary>
    /// 三方应用的用户id
    /// </summary>
    [JsonPropertyName("external_uid")]
    public string ExternalUid { get; set; }

    /// <summary>
    /// 当前店群包含的拼多多店铺id
    /// </summary>
    [JsonPropertyName("mall_list")]
    public List<long?> MallList { get; set; }

}

