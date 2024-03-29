namespace PddOpenSdk.Models.Request.Ad;
public partial class SyncAdApiUnitBid
{

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }

    /// <summary>
    /// 出价信息列表
    /// </summary>
    [JsonPropertyName("adUnitBids")]
    public List<AdUnitBidsModel> AdUnitBids { get; set; }

    /// <summary>
    /// 出价资源类型。1表示人群定向，2表示资源位。
    /// </summary>
    [JsonPropertyName("bidReferenceType")]
    public int BidReferenceType { get; set; }
    public partial class AdUnitBidsModel
    {

        /// <summary>
        /// 定向信息。仅支持地域定向。
        /// </summary>
        [JsonPropertyName("adTargetingVO")]
        public AdTargetingVOModel AdTargetingVO { get; set; }

        /// <summary>
        /// 可选人群定向类型或者可选资源位定向类型。人群定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.base.target.profile资源位定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.available.location
        /// </summary>
        [JsonPropertyName("bidReferenceId")]
        public long BidReferenceId { get; set; }

        /// <summary>
        /// 出价，万分比，10000表示100%
        /// </summary>
        [JsonPropertyName("bidValue")]
        public long BidValue { get; set; }

        /// <summary>
        /// 二级定向Id。默认为0。
        /// </summary>
        [JsonPropertyName("subBidReferenceId")]
        public long SubBidReferenceId { get; set; }
        public partial class AdTargetingVOModel
        {

            /// <summary>
            /// 定向集合
            /// </summary>
            [JsonPropertyName("adTargetingSet")]
            public AdTargetingSetModel AdTargetingSet { get; set; }

            /// <summary>
            /// 定向名称
            /// </summary>
            [JsonPropertyName("targetingName")]
            public string TargetingName { get; set; }
            public partial class AdTargetingSetModel
            {

                /// <summary>
                /// 地域定向
                /// </summary>
                [JsonPropertyName("areaStruct")]
                public AreaStructModel AreaStruct { get; set; }
                public partial class AreaStructModel
                {

                    /// <summary>
                    /// 地域Id列表。具体地域Id编码参见接口返回：pdd.ad.api.unit.bid.query.targeting.tag.list
                    /// </summary>
                    [JsonPropertyName("areaIds")]
                    public List<int?> AreaIds { get; set; }

                }

            }

        }

    }

}

