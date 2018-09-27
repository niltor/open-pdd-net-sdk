using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class AdPlanCreateResponse
    {

        /// <summary>
        /// Examples: 1267
        /// </summary>
        [JsonProperty("ad_plan_id")]
        public int AdPlanId { get; set; }
    }

    public class CreateAdPlanResponseModel
    {

        /// <summary>
        /// Examples: {"ad_plan_id":1267}
        /// </summary>
        [JsonProperty("ad_plan_create_response")]
        public AdPlanCreateResponse AdPlanCreateResponse { get; set; }
    }


}
