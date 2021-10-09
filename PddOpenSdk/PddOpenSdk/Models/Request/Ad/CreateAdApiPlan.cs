namespace PddOpenSdk.Models.Request.Ad;
public partial class CreateAdApiPlan
{

    /// <summary>
    /// 计划创建信息
    /// </summary>
    [JsonPropertyName("adPlanCreateMessage")]
    public AdPlanCreateMessageModel AdPlanCreateMessage { get; set; }

    /// <summary>
    /// 单元创建信息列表
    /// </summary>
    [JsonPropertyName("adUnitCreateComplexMessageList")]
    public List<AdUnitCreateComplexMessageListModel> AdUnitCreateComplexMessageList { get; set; }

    /// <summary>
    /// 推广策略。1：自定义推广，3：展示ocpc智能推广。不传时表示自定义推广
    /// </summary>
    [JsonPropertyName("planStrategy")]
    public int? PlanStrategy { get; set; }

    /// <summary>
    /// 场景类型。0表示搜索，2表示展示。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }
    public partial class AdPlanCreateMessageModel
    {

        /// <summary>
        /// 单日消耗
        /// </summary>
        [JsonPropertyName("maxCost")]
        public long MaxCost { get; set; }

        /// <summary>
        /// 分时折扣
        /// </summary>
        [JsonPropertyName("planDiscount")]
        public PlanDiscountModel PlanDiscount { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonPropertyName("planName")]
        public string PlanName { get; set; }
        public partial class PlanDiscountModel
        {

            /// <summary>
            /// 分时折扣配置
            /// </summary>
            [JsonPropertyName("discounts")]
            public List<DiscountsModel> Discounts { get; set; }
            public partial class DiscountsModel
            {

                /// <summary>
                /// 小时。0-23分别表示第1个小时到第24个小时。
                /// </summary>
                [JsonPropertyName("index")]
                public int Index { get; set; }

                /// <summary>
                /// 折扣比例。千分比（即rate等于1000表示比例100%）。
                /// </summary>
                [JsonPropertyName("rate")]
                public int Rate { get; set; }

            }

        }

    }
    public partial class AdUnitCreateComplexMessageListModel
    {

        /// <summary>
        /// 创意创建信息列表
        /// </summary>
        [JsonPropertyName("adCreativeCreateMessagesList")]
        public List<AdCreativeCreateMessagesListModel> AdCreativeCreateMessagesList { get; set; }

        /// <summary>
        /// 关键词创建列表
        /// </summary>
        [JsonPropertyName("adKeywordCreateMessageList")]
        public List<AdKeywordCreateMessageListModel> AdKeywordCreateMessageList { get; set; }

        /// <summary>
        /// 智能词包相关信息
        /// </summary>
        [JsonPropertyName("adKeywordSetMessage")]
        public AdKeywordSetMessageModel AdKeywordSetMessage { get; set; }

        /// <summary>
        /// 商品创建信息
        /// </summary>
        [JsonPropertyName("adProductCreateMessage")]
        public AdProductCreateMessageModel AdProductCreateMessage { get; set; }

        /// <summary>
        /// 单元创建信息
        /// </summary>
        [JsonPropertyName("adUnitCreateMessage")]
        public AdUnitCreateMessageModel AdUnitCreateMessage { get; set; }

        /// <summary>
        /// 人群定向创建信息列表
        /// </summary>
        [JsonPropertyName("audienceBidCreateMessageList")]
        public List<AudienceBidCreateMessageListModel> AudienceBidCreateMessageList { get; set; }

        /// <summary>
        /// 资源位定向创建信息列表。仅支持展示广告。
        /// </summary>
        [JsonPropertyName("locationBidCreateMessageList")]
        public List<LocationBidCreateMessageListModel> LocationBidCreateMessageList { get; set; }

        /// <summary>
        /// 智能创意创建信息
        /// </summary>
        [JsonPropertyName("smartCreativeCreateMessage")]
        public SmartCreativeCreateMessageModel SmartCreativeCreateMessage { get; set; }
        public partial class AdCreativeCreateMessagesListModel
        {

            /// <summary>
            /// 创意图片列表
            /// </summary>
            [JsonPropertyName("adImageVOList")]
            public List<AdImageVOListModel> AdImageVOList { get; set; }

            /// <summary>
            /// 创意标题列表
            /// </summary>
            [JsonPropertyName("adTextVOList")]
            public List<AdTextVOListModel> AdTextVOList { get; set; }

            /// <summary>
            /// 创意规格，6：商品轮播图，7：商品长图，其余规格暂不支持
            /// </summary>
            [JsonPropertyName("creativeSpecificationId")]
            public long CreativeSpecificationId { get; set; }
            public partial class AdImageVOListModel
            {

                /// <summary>
                /// 图片链接，可用图片参考以下接口返回：pdd.ad.api.goods.query.gallery.images（轮播图），pdd.ad.api.goods.query.long.images（长图）
                /// </summary>
                [JsonPropertyName("imageUrl")]
                public string ImageUrl { get; set; }

            }
            public partial class AdTextVOListModel
            {

                /// <summary>
                /// 标题
                /// </summary>
                [JsonPropertyName("text")]
                public string Text { get; set; }

            }

        }
        public partial class AdKeywordCreateMessageListModel
        {

            /// <summary>
            /// 关键词出价
            /// </summary>
            [JsonPropertyName("bid")]
            public long Bid { get; set; }

            /// <summary>
            /// 关键词溢价比例。万分比
            /// </summary>
            [JsonPropertyName("premiumRate")]
            public long? PremiumRate { get; set; }

            /// <summary>
            /// 关键词
            /// </summary>
            [JsonPropertyName("word")]
            public string Word { get; set; }

        }
        public partial class AdKeywordSetMessageModel
        {

            /// <summary>
            /// 词包出价。出价需在[0.10, 99.00]之间。
            /// </summary>
            [JsonPropertyName("keywordSetBid")]
            public long? KeywordSetBid { get; set; }

        }
        public partial class AdProductCreateMessageModel
        {

            /// <summary>
            /// 商品Id
            /// </summary>
            [JsonPropertyName("goodsId")]
            public long? GoodsId { get; set; }

        }
        public partial class AdUnitCreateMessageModel
        {

            /// <summary>
            /// 推广单元名称
            /// </summary>
            [JsonPropertyName("adName")]
            public string AdName { get; set; }

            /// <summary>
            /// 基础出价。单位厘。
            /// </summary>
            [JsonPropertyName("bid")]
            public long? Bid { get; set; }

            /// <summary>
            /// 智能优化广告相关。当单元使用自定义推广时，不要使用该字段。
            /// </summary>
            [JsonPropertyName("optimizationMessage")]
            public OptimizationMessageModel OptimizationMessage { get; set; }
            public partial class OptimizationMessageModel
            {

                /// <summary>
                /// 数据积累期出价。当使用OCPX时对该字段赋值。
                /// </summary>
                [JsonPropertyName("accumulationBid")]
                public long? AccumulationBid { get; set; }

                /// <summary>
                /// 智能投放期出价。当使用OCPX时对该字段赋值。
                /// </summary>
                [JsonPropertyName("optimizationBid")]
                public long? OptimizationBid { get; set; }

                /// <summary>
                /// 优化目标。0表示不优化。1表示优化ROI，2表示优化转化成本.自定义单元时，该值必传0；当单元使用展示自动调价功能(ECPC)时，该值必须传1；当单元使用展示OCPC功能（plan_strategy=3）时，该值必须传2。
                /// </summary>
                [JsonPropertyName("optimizationGoal")]
                public int OptimizationGoal { get; set; }

                /// <summary>
                /// 优化方式。0表示不优化，1表示ECPC，2表示OCPC。当单元使用ECPC时，该值必须传1；当使用OCPC时，该值必须传2。
                /// </summary>
                [JsonPropertyName("optimizationMethod")]
                public int? OptimizationMethod { get; set; }

                /// <summary>
                /// 可选优化出价列表。当使用OCPX时对该字段赋值。
                /// </summary>
                [JsonPropertyName("optionalOptimizationBidMessageList")]
                public List<OptionalOptimizationBidMessageListModel> OptionalOptimizationBidMessageList { get; set; }
                public partial class OptionalOptimizationBidMessageListModel
                {

                    /// <summary>
                    /// 可选优化出价价格
                    /// </summary>
                    [JsonPropertyName("optimizationBid")]
                    public long OptimizationBid { get; set; }

                    /// <summary>
                    /// 可选优化出价目标。3表示优化店铺关注，4表示优化商品收藏，5表示优化询单
                    /// </summary>
                    [JsonPropertyName("optimizationGoal")]
                    public int OptimizationGoal { get; set; }

                }

            }

        }
        public partial class AudienceBidCreateMessageListModel
        {

            /// <summary>
            /// 定向创建信息
            /// </summary>
            [JsonPropertyName("adTargetingCreateMessage")]
            public AdTargetingCreateMessageModel AdTargetingCreateMessage { get; set; }

            /// <summary>
            /// 人群定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.base.target.profile
            /// </summary>
            [JsonPropertyName("bidReferenceId")]
            public long BidReferenceId { get; set; }

            /// <summary>
            /// 出价，万分比
            /// </summary>
            [JsonPropertyName("bidValue")]
            public long BidValue { get; set; }

            /// <summary>
            /// 人群定向二级Id。默认为0。
            /// </summary>
            [JsonPropertyName("subBidReferenceId")]
            public long SubBidReferenceId { get; set; }
            public partial class AdTargetingCreateMessageModel
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
                        public List<int> AreaIds { get; set; }

                    }

                }

            }

        }
        public partial class LocationBidCreateMessageListModel
        {

            /// <summary>
            /// 资源位定向类型。可取值参考接口：pdd.ad.api.unit.bid.query.available.location
            /// </summary>
            [JsonPropertyName("bidReferenceId")]
            public long BidReferenceId { get; set; }

            /// <summary>
            /// 出价，万分比
            /// </summary>
            [JsonPropertyName("bidValue")]
            public long BidValue { get; set; }

        }
        public partial class SmartCreativeCreateMessageModel
        {

            /// <summary>
            /// 智能创意流量分配比例
            /// </summary>
            [JsonPropertyName("creativeFlowRate")]
            public int? CreativeFlowRate { get; set; }

            /// <summary>
            /// 是否启用智能创意标识
            /// </summary>
            [JsonPropertyName("enableSmartCreative")]
            public int? EnableSmartCreative { get; set; }

            /// <summary>
            /// 智能创意标题
            /// </summary>
            [JsonPropertyName("smartCreativeTitle")]
            public string SmartCreativeTitle { get; set; }

        }

    }

}

