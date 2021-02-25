using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class UpdateAdApiUnitBidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 更新列表
        /// </summary>
        [JsonProperty("adUnitBids")]
        public List<AdUnitBidsRequestModel> AdUnitBids { get; set; }
        /// <summary>
        /// 出价资源类型。1表示人群定向，2表示资源位。
        /// </summary>
        [JsonProperty("bidReferenceType")]
        public int BidReferenceType { get; set; }
        public partial class AdUnitBidsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 出价Id
            /// </summary>
            [JsonProperty("bidId")]
            public long BidId { get; set; }
            /// <summary>
            /// 出价，万分比
            /// </summary>
            [JsonProperty("bidValue")]
            public long BidValue { get; set; }

        }

    }

}
