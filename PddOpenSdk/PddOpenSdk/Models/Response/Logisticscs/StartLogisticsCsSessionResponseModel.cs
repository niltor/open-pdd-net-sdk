using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsCsSessionStartResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class StartLogisticsCsSessionResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("logistics_cs_session_start_response")]
        public LogisticsCsSessionStartResponse LogisticsCsSessionStartResponse { get; set; }
    }


}
