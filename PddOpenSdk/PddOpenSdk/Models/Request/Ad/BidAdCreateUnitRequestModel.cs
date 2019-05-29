using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class BidAdCreateUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// 定向人群列表
        /// </summary>
        [JsonProperty("bids")]
        public List<BidsRequestModel> Bids { get; set; }
        public partial class BidsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 非通投时填	; 溢价比例，存储的是整数，比如2013，实际表示的是溢价20.13%; ; 溢价比例最低值为10%，最高为300%
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int BidPremiumRate { get; set; }
            /// <summary>
            /// 通投时填 , 溢价绝对值，单位厘
            /// </summary>
            [JsonProperty("bid")]
            public long? Bid { get; set; }
            /// <summary>
            /// 兴趣点ID，targetType不为6/7时，传 0
            /// </summary>
            [JsonProperty("sub_level_target_id")]
            public long SubLevelTargetId { get; set; }
            /// <summary>
            /// 1：通投（必有）; 2：访客重定向; 3：相似商品定向; 4：叶子类目定向; 5：相似店铺定向; 6：近期对我的商品相关属性感兴趣的用户; 7：人群包定向
            /// </summary>
            [JsonProperty("target_type")]
            public int TargetType { get; set; }

        }

    }

}
