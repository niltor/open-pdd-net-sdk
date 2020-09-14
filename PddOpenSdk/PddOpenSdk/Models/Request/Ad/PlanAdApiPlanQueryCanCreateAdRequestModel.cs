using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class PlanAdApiPlanQueryCanCreateAdRequestModel : PddRequestModel
    {
        /// <summary>
        /// 单元名称
        /// </summary>
        [JsonProperty("planName")]
        public string PlanName { get; set; }
        /// <summary>
        /// 场景类型。0表示搜索，2表示展示。
        /// </summary>
        [JsonProperty("scenesType")]
        public int ScenesType { get; set; }

    }

}
