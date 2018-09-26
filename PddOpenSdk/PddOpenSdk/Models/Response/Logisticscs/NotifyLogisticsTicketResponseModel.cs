using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsTicketNotifyResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class NotifyLogisticsTicketResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("logistics_ticket_notify_response")]
        public LogisticsTicketNotifyResponse LogisticsTicketNotifyResponse { get; set; }
    }


}
