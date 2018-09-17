using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class StartLogisticsCsSessionResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_session_start_response")]
        public object LogisticsCsSessionStartResponse { get; set; }

        public partial class LogisticsCsSessionStartResponseResponseModel : PddResponseModel
        {

        }

    }
}
