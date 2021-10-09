namespace PddOpenSdk.Models.Response.Ad;
public partial class ListAdApiUnitBidQueryResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 广告单元Id
            /// </summary>
            [JsonPropertyName("adId")]
            public long? AdId { get; set; }

            /// <summary>
            /// 定向信息
            /// </summary>
            [JsonPropertyName("adTargetingVO")]
            public AdTargetingVOResponse AdTargetingVO { get; set; }

            /// <summary>
            /// 每笔成交金额(average pay amount)，单位厘
            /// </summary>
            [JsonPropertyName("avgPayAmount")]
            public double? AvgPayAmount { get; set; }

            /// <summary>
            /// 出价Id
            /// </summary>
            [JsonPropertyName("bidId")]
            public long? BidId { get; set; }

            /// <summary>
            /// 定向类型 或 资源位类型
            /// </summary>
            [JsonPropertyName("bidReferenceId")]
            public long? BidReferenceId { get; set; }

            /// <summary>
            /// 出价，万分比
            /// </summary>
            [JsonPropertyName("bidValue")]
            public long? BidValue { get; set; }

            /// <summary>
            /// 广告点击量
            /// </summary>
            [JsonPropertyName("click")]
            public long? Click { get; set; }

            /// <summary>
            /// 平均点击花费，单位厘
            /// </summary>
            [JsonPropertyName("cpc")]
            public double? Cpc { get; set; }

            /// <summary>
            /// 千次展现成本
            /// </summary>
            [JsonPropertyName("cpm")]
            public double? Cpm { get; set; }

            /// <summary>
            /// 广告点击率
            /// </summary>
            [JsonPropertyName("ctr")]
            public double? Ctr { get; set; }

            /// <summary>
            /// 点击转化率
            /// </summary>
            [JsonPropertyName("cvr")]
            public double? Cvr { get; set; }

            /// <summary>
            /// 广告转化支付金额，单位厘
            /// </summary>
            [JsonPropertyName("gmv")]
            public long? Gmv { get; set; }

            /// <summary>
            /// 商品收藏数
            /// </summary>
            [JsonPropertyName("goodsFavNum")]
            public long? GoodsFavNum { get; set; }

            /// <summary>
            /// 广告曝光量
            /// </summary>
            [JsonPropertyName("impression")]
            public long? Impression { get; set; }

            /// <summary>
            /// 店铺收藏数
            /// </summary>
            [JsonPropertyName("mallFavNum")]
            public long? MallFavNum { get; set; }

            /// <summary>
            /// 广告主Id
            /// </summary>
            [JsonPropertyName("mallId")]
            public long? MallId { get; set; }

            /// <summary>
            /// 广告转化支付订单量
            /// </summary>
            [JsonPropertyName("orderNum")]
            public long? OrderNum { get; set; }

            /// <summary>
            /// 广告投入产出比
            /// </summary>
            [JsonPropertyName("roi")]
            public double? Roi { get; set; }

            /// <summary>
            /// 广告消耗，单位厘
            /// </summary>
            [JsonPropertyName("spend")]
            public long? Spend { get; set; }

            /// <summary>
            /// 人群定向二级Id。当出价资源为展示场景兴趣点时表示兴趣点Id，当出价资源为展示场景人群包时表示人群包Id，当出价资源为展示场景地域时表示地域Id。
            /// </summary>
            [JsonPropertyName("subBidReferenceId")]
            public string SubBidReferenceId { get; set; }

            /// <summary>
            /// 人群定向二级名称。当出价资源为展示场景兴趣点时表示兴趣点名称，当出价资源为展示场景人群包时表示人群包名称，当出价资源为展示场景地域时表示地域名称。
            /// </summary>
            [JsonPropertyName("subBidReferenceName")]
            public string SubBidReferenceName { get; set; }

            /// <summary>
            /// 转化成本
            /// </summary>
            [JsonPropertyName("transactionCost")]
            public double? TransactionCost { get; set; }
            public partial class AdTargetingVOResponse : PddResponseModel
            {

                /// <summary>
                /// 定向集合
                /// </summary>
                [JsonPropertyName("adTargetingSet")]
                public AdTargetingSetResponse AdTargetingSet { get; set; }

                /// <summary>
                /// 定向Id
                /// </summary>
                [JsonPropertyName("targetingId")]
                public long? TargetingId { get; set; }

                /// <summary>
                /// 定向名称
                /// </summary>
                [JsonPropertyName("targetingName")]
                public string TargetingName { get; set; }
                public partial class AdTargetingSetResponse : PddResponseModel
                {

                    /// <summary>
                    /// 地域定向
                    /// </summary>
                    [JsonPropertyName("areaStruct")]
                    public AreaStructResponse AreaStruct { get; set; }
                    public partial class AreaStructResponse : PddResponseModel
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

}

