using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class SyncAdApiUnitBidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 出价信息列表
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
            /// 定向信息。仅支持地域定向和天气定向。
            /// </summary>
            [JsonProperty("adTargetingVO")]
            public AdTargetingVORequestModel AdTargetingVO { get; set; }
            /// <summary>
            /// 可选人群定向类型或者可选资源位定向类型。人群定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.base.target.profile资源位定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.available.location
            /// </summary>
            [JsonProperty("bidReferenceId")]
            public long BidReferenceId { get; set; }
            /// <summary>
            /// 出价，万分比，10000表示100%
            /// </summary>
            [JsonProperty("bidValue")]
            public long BidValue { get; set; }
            /// <summary>
            /// 二级定向Id。当出价资源位展示场景人群定向下的兴趣点或人群包时，该字段必须赋值且值不得为0。
            /// </summary>
            [JsonProperty("subBidReferenceId")]
            public long SubBidReferenceId { get; set; }
            public partial class AdTargetingVORequestModel : PddRequestModel
            {
                /// <summary>
                /// 定向集合
                /// </summary>
                [JsonProperty("adTargetingSet")]
                public AdTargetingSetRequestModel AdTargetingSet { get; set; }
                /// <summary>
                /// 定向名称
                /// </summary>
                [JsonProperty("targetingName")]
                public string TargetingName { get; set; }
                public partial class AdTargetingSetRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 地域定向
                    /// </summary>
                    [JsonProperty("areaStruct")]
                    public AreaStructRequestModel AreaStruct { get; set; }
                    public partial class AreaStructRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 地域Id列表。具体地域Id编码参见接口返回：pdd.ad.api.unit.bid.query.targeting.tag.list
                        /// </summary>
                        [JsonProperty("areaIds")]
                        public int? AreaIds { get; set; }

                    }

                }

            }

        }

    }

}
