using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
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
        /// List<JsonObject> 的json string. 示例：[{"rate":1000,"index":12},{"rate":1000,"index":13}]
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
            /// 折扣率，1000 表示 100.0%，0 表示不投放，自定义范围 500 ~ 3000（10的倍数）
            /// </summary>
            [JsonProperty("rate")]
            public int Rate { get; set; }
            /// <summary>
            /// 时间段索引，0 ~ 23
            /// </summary>
            [JsonProperty("index")]
            public int Index { get; set; }

        }

    }

}
