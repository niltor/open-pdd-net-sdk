using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mallticket
{
    public partial class NotifyMallTicketResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_ticket_notify_respone")]
        public MallTicketNotifyResponeResponseModel MallTicketNotifyRespone { get; set; }
        public partial class MallTicketNotifyResponeResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
