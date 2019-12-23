using System.Collections.Generic;
using Newtonsoft.Json;
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
            /// 定向类型。1表示通投，2表示访客重定向，3表示相似商品定向，4表示叶子类目定向，5表示相似店铺定向，6表示兴趣点定向，7表示人群包定向，8表示地域定向人群，9表示商品高潜人群，10表示高品质商品偏好人群，11表示大促偏好人群，12表示爱分享人群
            /// </summary>
            [JsonProperty("target_type")]
            public int TargetType { get; set; }

        }

    }

}
