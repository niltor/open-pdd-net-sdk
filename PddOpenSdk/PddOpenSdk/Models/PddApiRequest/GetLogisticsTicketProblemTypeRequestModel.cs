using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetLogisticsTicketProblemTypeRequestModel : PddRequestModel
    {
        /// <summary>
        /// pdd.logistics.ticket.problem.type.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }

    }
}
