using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logisticscs
{
    public partial class GetLogisticsTicketProblemTypeRequestModel : PddRequestModel
    {
        /// <summary>
        /// pdd.logistics.ticket.problem.type.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }

}
