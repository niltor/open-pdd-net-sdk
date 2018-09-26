using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsCsMessageSendResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class SendLogisticsCsMessageResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("logistics_cs_message_send_response")]
        public LogisticsCsMessageSendResponse LogisticsCsMessageSendResponse { get; set; }
    }


}
