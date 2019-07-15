using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class PlanAdCanCreateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("ad_plan_create_response")]
        public AdPlanCreateResponseResponseModel AdPlanCreateResponse { get; set; }
        public partial class AdPlanCreateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否可以创建
            /// </summary>
            [JsonProperty("creatable")]
            public bool? Creatable { get; set; }

        }

    }

}
