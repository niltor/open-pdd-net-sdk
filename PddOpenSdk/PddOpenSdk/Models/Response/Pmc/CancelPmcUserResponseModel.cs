using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Pmc
{
    public partial class CancelPmcUserResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("tmc_user_cancel_response")]
        public TmcUserCancelResponseResponseModel TmcUserCancelResponse { get; set; }
        public partial class TmcUserCancelResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
