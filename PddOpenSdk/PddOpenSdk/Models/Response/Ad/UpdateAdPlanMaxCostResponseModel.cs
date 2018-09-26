using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanMaxCostUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateAdPlanMaxCostResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_plan_max_cost_update_response")]
        public AdPlanMaxCostUpdateResponse AdPlanMaxCostUpdateResponse { get; set; }
    }


}
