using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class BidAdCreateLocationRequestModel : PddRequestModel
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
        /// 
        /// </summary>
        [JsonProperty("location_bids")]
        public List<LocationBidsRequestModel> LocationBids { get; set; }
        public partial class LocationBidsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 溢价比例，存储的是整数，100 表示 1%，支持设置 1%-300%
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int BidPremiumRate { get; set; }
            /// <summary>
            /// 资源位类型（1：类目商品页，2：商品详情页，3：营销活动页）
            /// </summary>
            [JsonProperty("location_type")]
            public int LocationType { get; set; }

        }

    }

}
