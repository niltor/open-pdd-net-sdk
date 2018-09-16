using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsTicketResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ticket_get_response")]
public object LogisticsTicketGetResponse {get;set;}

    public partial class LogisticsTicketGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
