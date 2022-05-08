namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class GetLogisticsCsHistoryMessage
{

    /// <summary>
    /// pdd会话id
    /// </summary>
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }

}

