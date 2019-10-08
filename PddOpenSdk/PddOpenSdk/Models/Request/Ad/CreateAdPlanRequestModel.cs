using Newtonsoft.Json;
using System.Collections.Generic;
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
        /// 单日消耗，单位厘;上限不能超过1000000元，单日消耗上限不能低于100元 , 默认不限额，即1000000 元
        /// </summary>
        [JsonProperty("max_cost")]
        public long? MaxCost { get; set; }
        /// <summary>
        /// List<JsonObject> 的json string. 示例：[{"rate":1000,"index":12},{"rate":1000,"index":13}]
        /// </summary>
        [JsonProperty("discounts")]
        public List<DiscountsRequestModel> Discounts { get; set; }
        public partial class DiscountsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 折扣率，1000 表示 100.0%，0 表示不投放，自定义范围 500 ~ 3000（10的倍数）
            /// </summary>
            [JsonProperty("rate")]
            public int? Rate { get; set; }
            /// <summary>
            /// 时间段索引，0 ~ 23
            /// </summary>
            [JsonProperty("index")]
            public int? Index { get; set; }

        }

    }

}
