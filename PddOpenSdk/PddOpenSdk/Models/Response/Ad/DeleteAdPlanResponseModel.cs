using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanDeleteResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeleteAdPlanResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_plan_delete_response")]
        public AdPlanDeleteResponse AdPlanDeleteResponse { get; set; }
    }


}
