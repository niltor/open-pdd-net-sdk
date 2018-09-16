using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class NotifyLogisticsTicketResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ticket_notify_response")]
public object LogisticsTicketNotifyResponse {get;set;}

    public partial class LogisticsTicketNotifyResponseResponseModel : PddResponseModel
    {
        
}

}
}
