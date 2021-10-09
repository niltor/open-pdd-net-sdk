namespace PddOpenSdk.Models.Request.DdkTools;
public partial class BindDdkOauthPidMediaid
{

    /// <summary>
    /// 媒体id
    /// </summary>
    [JsonPropertyName("media_id")]
    public long MediaId { get; set; }

    /// <summary>
    /// 推广位列表，例如：["60005_612"]，最多支持同时传入1000个
    /// </summary>
    [JsonPropertyName("pid_list")]
    public List<string> PidList { get; set; }

}

