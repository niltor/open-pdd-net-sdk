using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class DeletingSmsSellResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("sms_sell_deleting_response")]
        public SmsSellDeletingResponseResponseModel SmsSellDeletingResponse { get; set; }
        public partial class SmsSellDeletingResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}