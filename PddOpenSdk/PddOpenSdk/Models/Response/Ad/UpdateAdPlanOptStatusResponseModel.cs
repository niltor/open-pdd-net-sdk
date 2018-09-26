using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanOptStatusUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateAdPlanOptStatusResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_plan_opt_status_update_response")]
        public AdPlanOptStatusUpdateResponse AdPlanOptStatusUpdateResponse { get; set; }
    }


}
