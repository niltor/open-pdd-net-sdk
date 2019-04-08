using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class UpdateAdUnitOptStatusResponseModel : PddResponseModel {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty ("ad_unit_opt_status_update_response")]
        public AdUnitOptStatusUpdateResponseResponseModel AdUnitOptStatusUpdateResponse { get; set; }
        public partial class AdUnitOptStatusUpdateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}