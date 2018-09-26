using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanCreateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("creatable")]
        public bool Creatable { get; set; }
    }

    public class PlanAdCanCreateResponseModel
    {

        /// <summary>
        /// Examples: {"creatable":true}
        /// </summary>
        [JsonProperty("ad_plan_create_response")]
        public AdPlanCreateResponse AdPlanCreateResponse { get; set; }
    }


}
