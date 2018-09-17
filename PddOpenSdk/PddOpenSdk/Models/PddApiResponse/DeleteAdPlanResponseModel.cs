using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DeleteAdPlanResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_plan_delete_response")]
        public object AdPlanDeleteResponse { get; set; }

        public partial class AdPlanDeleteResponseResponseModel : PddResponseModel
        {

        }

    }
}
