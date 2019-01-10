using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class BidAdUpdateRequestModel : PddRequestModel
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
        /// 定向列表
        /// </summary>
        [JsonProperty("bid_list")]
        public BidListRequestModel BidList { get; set; }
        public partial class BidListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 非通投必填	; 溢价比例，存储的是整数，比如2013，实际表示的是溢价20.13%; ; 溢价比例最低值为10%，最高为300%
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int? BidPremiumRate { get; set; }
            /// <summary>
            /// 通投必填	溢价绝对值，单位厘，通投时，使用这个值，其他情况使用bid_premium_rate
            /// </summary>
            [JsonProperty("bid")]
            public long? Bid { get; set; }
            /// <summary>
            /// 定向ID
            /// </summary>
            [JsonProperty("bid_id")]
            public long BidId { get; set; }

        }

    }

}
