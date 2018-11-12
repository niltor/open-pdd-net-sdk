using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class UpdateAdPlanDiscountRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广计划id
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }
        /// <summary>
        /// List<JsonObject> 的json string. 示例：[{"rate":12,"index":34},{"rate":56,"index":78}]
        /// </summary>
        [JsonProperty("discounts")]
        public List<DiscountsRequestModel> Discounts { get; set; }
        /// <summary>
        /// 0 :搜索广告
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        public partial class DiscountsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("rate")]
            public int Rate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("index")]
            public int Index { get; set; }

        }

    }

}
