using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsCsHistoryMessageResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_history_message_get_response")]
        public object LogisticsCsHistoryMessageGetResponse { get; set; }

        public partial class LogisticsCsHistoryMessageGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
