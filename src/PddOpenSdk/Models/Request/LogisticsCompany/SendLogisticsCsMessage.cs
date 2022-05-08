namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class SendLogisticsCsMessage
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

    /// <summary>
    /// 0：文本1：图片
    /// </summary>
    [JsonPropertyName("message_type")]
    public int MessageType { get; set; }

    /// <summary>
    /// message_type为0时不为空
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// message_type为1时不为空
    /// </summary>
    [JsonPropertyName("attach")]
    public string Attach { get; set; }

    /// <summary>
    /// message_type为1时不为空
    /// </summary>
    [JsonPropertyName("preview")]
    public string Preview { get; set; }

}

