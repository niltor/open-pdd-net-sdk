using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DeleteAdPlanRequestModel : PddRequestModel
    {
        /// <summary>
        /// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// plan_id 列表，示例：[1,2]
        /// </summary>
        [JsonProperty("plan_ids")]
        public List<long> PlanIds { get; set; }

    }

}
