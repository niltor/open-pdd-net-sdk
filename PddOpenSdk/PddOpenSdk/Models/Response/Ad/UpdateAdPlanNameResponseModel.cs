using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanNameUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateAdPlanNameResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_plan_name_update_response")]
        public AdPlanNameUpdateResponse AdPlanNameUpdateResponse { get; set; }
    }


}
