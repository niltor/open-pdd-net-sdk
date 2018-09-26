using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdPlanRequestModel : PddRequestModel
    {
        /// <summary>
        /// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 计划名
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }
        /// <summary>
        /// 单日消耗，单位厘;上限不能超过1000000元，单日消耗上限不能低于100元
        /// </summary>
        [JsonProperty("max_cost")]
        public int MaxCost { get; set; }

    }

}
