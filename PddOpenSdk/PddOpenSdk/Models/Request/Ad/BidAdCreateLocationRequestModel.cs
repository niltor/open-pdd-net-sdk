using System.Collections.Generic;
using Newtonsoft.Json;
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
        /// location_bids
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
            /// 资源位类型。0表示基础流量包，1表示类目商品页，2表示商品详情页，3表示营销活动页，4表示店铺收藏页，5表示订单评价页，6表示优选活动页
            /// </summary>
            [JsonProperty("location_type")]
            public int LocationType { get; set; }

        }

    }

}
