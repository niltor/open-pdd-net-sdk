using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsCsSessionCloseResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class CloseLogisticsCsSessionResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("logistics_cs_session_close_response")]
        public LogisticsCsSessionCloseResponse LogisticsCsSessionCloseResponse { get; set; }
    }


}
