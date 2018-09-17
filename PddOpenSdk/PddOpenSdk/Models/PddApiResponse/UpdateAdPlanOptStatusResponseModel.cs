using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdPlanOptStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_plan_opt_status_update_response")]
        public object AdPlanOptStatusUpdateResponse { get; set; }

        public partial class AdPlanOptStatusUpdateResponseResponseModel : PddResponseModel
        {

        }

    }
}
