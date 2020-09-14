using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ticket
{
    public partial class NotifycationTicketOrderCreateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
