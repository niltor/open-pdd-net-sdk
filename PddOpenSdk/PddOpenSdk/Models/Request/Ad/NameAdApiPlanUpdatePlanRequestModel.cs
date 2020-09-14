using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class NameAdApiPlanUpdatePlanRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告计划Id
        /// </summary>
        [JsonProperty("planId")]
        public long PlanId { get; set; }
        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("planName")]
        public string PlanName { get; set; }

    }

}
