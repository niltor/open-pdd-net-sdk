using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetLogisticsTicketProblemTypeRequestModel : PddRequestModel
    {
        /// <summary>
/// pdd.logistics.ticket.problem.type.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}

}
}
