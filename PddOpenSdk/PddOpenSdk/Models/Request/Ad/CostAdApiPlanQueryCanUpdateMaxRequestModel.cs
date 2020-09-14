using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CostAdApiPlanQueryCanUpdateMaxRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告计划Id
        /// </summary>
        [JsonProperty("planId")]
        public long PlanId { get; set; }

    }

}
