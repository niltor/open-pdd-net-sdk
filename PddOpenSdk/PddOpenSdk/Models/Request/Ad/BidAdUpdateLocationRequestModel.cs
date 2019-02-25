using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class BidAdUpdateLocationRequestModel : PddRequestModel
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
        [JsonProperty("location_bid_list")]
        public List<LocationBidListRequestModel> LocationBidList { get; set; }
        public partial class LocationBidListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 溢价比例，例如2013，实际表示的是溢价20.13%，支持设置 1%-300%
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int BidPremiumRate { get; set; }
            /// <summary>
            /// 资源位id
            /// </summary>
            [JsonProperty("location_bid_id")]
            public long LocationBidId { get; set; }

        }

    }

}
