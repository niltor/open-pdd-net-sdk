using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logisticsticket
{
    public partial class GetLogisticsCsHistoryMessageRequestModel : PddRequestModel {
        /// <summary>
        /// pdd会话id
        /// </summary>
        [JsonProperty ("session_id")]
        public string SessionId { get; set; }

    }

}