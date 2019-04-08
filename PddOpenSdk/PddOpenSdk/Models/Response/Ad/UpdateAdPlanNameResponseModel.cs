using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class UpdateAdPlanNameResponseModel : PddResponseModel {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty ("ad_plan_name_update_response")]
        public AdPlanNameUpdateResponseResponseModel AdPlanNameUpdateResponse { get; set; }
        public partial class AdPlanNameUpdateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}