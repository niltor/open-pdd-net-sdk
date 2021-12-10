namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class StartLogisticsCsSessionResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_cs_session_start_response")]
    public LogisticsCsSessionStartResponseResponse LogisticsCsSessionStartResponse { get; set; }
    public partial class LogisticsCsSessionStartResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

