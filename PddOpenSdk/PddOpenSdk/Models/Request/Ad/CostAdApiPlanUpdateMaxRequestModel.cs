using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CostAdApiPlanUpdateMaxRequestModel : PddRequestModel
    {
        /// <summary>
        /// 日消耗上限。单位厘。
        /// </summary>
        [JsonProperty("maxCost")]
        public long MaxCost { get; set; }
        /// <summary>
        /// 广告计划Id
        /// </summary>
        [JsonProperty("planId")]
        public long PlanId { get; set; }

    }

}
