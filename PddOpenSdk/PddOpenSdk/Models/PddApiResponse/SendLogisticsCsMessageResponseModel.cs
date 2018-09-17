using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SendLogisticsCsMessageResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_message_send_response")]
        public object LogisticsCsMessageSendResponse { get; set; }

        public partial class LogisticsCsMessageSendResponseResponseModel : PddResponseModel
        {

        }

    }
}
