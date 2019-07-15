using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class UpdateAdPlanMaxCostResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_plan_max_cost_update_response")]
        public AdPlanMaxCostUpdateResponseResponseModel AdPlanMaxCostUpdateResponse { get; set; }
        public partial class AdPlanMaxCostUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
