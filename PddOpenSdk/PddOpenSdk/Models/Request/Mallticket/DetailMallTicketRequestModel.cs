using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mallticket
{
    public partial class DetailMallTicketRequestModel : PddRequestModel
    {
        /// <summary>
        /// 工单编号
        /// </summary>
        [JsonProperty("ticket_id")]
        public string TicketId { get; set; }

    }

}
