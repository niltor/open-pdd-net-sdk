namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class CloseLogisticsCsSession
{

    /// <summary>
    /// pdd会话id
    /// </summary>
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }

    /// <summary>
    /// 物流公司会话id
    /// </summary>
    [JsonPropertyName("wp_session_id")]
    public string WpSessionId { get; set; }

    /// <summary>
    /// 样式YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonPropertyName("action_time")]
    public string ActionTime { get; set; }

}

