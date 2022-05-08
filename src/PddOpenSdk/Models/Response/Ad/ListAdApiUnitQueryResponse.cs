namespace PddOpenSdk.Models.Response.Ad;
public partial class ListAdApiUnitQueryResponse : PddResponseModel
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
            /// 每笔成交金额(average pay amount)，单位厘
            /// </summary>
            [JsonPropertyName("avgPayAmount")]
            public double? AvgPayAmount { get; set; }

            /// <summary>
            /// 广告单元出价。单位厘
            /// </summary>
            [JsonPropertyName("bid")]
            public long? Bid { get; set; }

            /// <summary>
            /// 类目ID
            /// </summary>
            [JsonPropertyName("catId")]
            public long? CatId { get; set; }

            /// <summary>
            /// 类目名称
            /// </summary>
            [JsonPropertyName("catName")]
            public string CatName { get; set; }

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
            /// 智能推广数据积累状态。0表示未知，1表示智能投放期，2表示数据积累期，3表示数据积累缓慢。
            /// </summary>
            [JsonPropertyName("dataAccumulationStatus")]
            public int? DataAccumulationStatus { get; set; }

            /// <summary>
            /// 操作状态。0表示未知，1表示启用，2表示暂停。
            /// </summary>
            [JsonPropertyName("dataOperateStatus")]
            public int? DataOperateStatus { get; set; }

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
            /// 商品ID
            /// </summary>
            [JsonPropertyName("goodsId")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goodsName")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 广告曝光量
            /// </summary>
            [JsonPropertyName("impression")]
            public long? Impression { get; set; }

            /// <summary>
            /// 店铺关注数
            /// </summary>
            [JsonPropertyName("mallFavNum")]
            public long? MallFavNum { get; set; }

            /// <summary>
            /// 广告主ID
            /// </summary>
            [JsonPropertyName("mallId")]
            public long? MallId { get; set; }

            /// <summary>
            /// 最大团购价。单位厘
            /// </summary>
            [JsonPropertyName("maxGroupPrice")]
            public long? MaxGroupPrice { get; set; }

            /// <summary>
            /// 最小团购价。单位厘
            /// </summary>
            [JsonPropertyName("minGroupPrice")]
            public long? MinGroupPrice { get; set; }

            /// <summary>
            /// 优化目标。0表示不优化。1表示优化ROI，2表示优化转化成本。
            /// </summary>
            [JsonPropertyName("optimizationGoal")]
            public int? OptimizationGoal { get; set; }

            /// <summary>
            /// 智能优化广告相关
            /// </summary>
            [JsonPropertyName("optimizationOutputMessage")]
            public OptimizationOutputMessageResponse OptimizationOutputMessage { get; set; }

            /// <summary>
            /// 广告转化支付订单量
            /// </summary>
            [JsonPropertyName("orderNum")]
            public long? OrderNum { get; set; }

            /// <summary>
            /// 广告计划ID
            /// </summary>
            [JsonPropertyName("planId")]
            public long? PlanId { get; set; }

            /// <summary>
            /// 广告计划名称
            /// </summary>
            [JsonPropertyName("planName")]
            public string PlanName { get; set; }

            /// <summary>
            /// 推广策略。0表示未知，1表示自定义推广，2表示智能推广。
            /// </summary>
            [JsonPropertyName("planStrategy")]
            public int? PlanStrategy { get; set; }

            /// <summary>
            /// 广告惩罚原因
            /// </summary>
            [JsonPropertyName("punishReason")]
            public string PunishReason { get; set; }

            /// <summary>
            /// 广告投入产出比
            /// </summary>
            [JsonPropertyName("roi")]
            public double? Roi { get; set; }

            /// <summary>
            /// 广告消耗,单位厘
            /// </summary>
            [JsonPropertyName("spend")]
            public long? Spend { get; set; }

            /// <summary>
            /// 单元状态。1表示推广中，2表示手动暂停，3表示商品售罄，4表示商品下架，5表示限制推广，6表示已删除，7表示审核中，8表示无推广中创意，9表示审核驳回。
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 商品图
            /// </summary>
            [JsonPropertyName("thumbUrl")]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// 转化成本
            /// </summary>
            [JsonPropertyName("transactionCost")]
            public double? TransactionCost { get; set; }

            /// <summary>
            /// 广告单元ID
            /// </summary>
            [JsonPropertyName("unitId")]
            public long? UnitId { get; set; }

            /// <summary>
            /// 广告单元名称
            /// </summary>
            [JsonPropertyName("unitName")]
            public string UnitName { get; set; }
            public partial class OptimizationOutputMessageResponse : PddResponseModel
            {

                /// <summary>
                /// 优化出价
                /// </summary>
                [JsonPropertyName("optimizationBid")]
                public long? OptimizationBid { get; set; }

                /// <summary>
                /// 优化启用时间。启用优化时未必立即开始，取决于数据积累状态。
                /// </summary>
                [JsonPropertyName("optimizationEnableTime")]
                public string OptimizationEnableTime { get; set; }

                /// <summary>
                /// 优化目标。0表示不优化。1表示优化ROI，2表示优化转化成本。
                /// </summary>
                [JsonPropertyName("optimizationGoal")]
                public int? OptimizationGoal { get; set; }

                /// <summary>
                /// 优化方式。0表示不优化，1表示ECPC，2表示OCPC。
                /// </summary>
                [JsonPropertyName("optimizationMethod")]
                public int? OptimizationMethod { get; set; }

                /// <summary>
                /// 优化开始时间
                /// </summary>
                [JsonPropertyName("optimizationStartTime")]
                public string OptimizationStartTime { get; set; }

                /// <summary>
                /// 可选优化目标信息列表
                /// </summary>
                [JsonPropertyName("optionalOptimizationBidOutputMessageList")]
                public List<OptionalOptimizationBidOutputMessageListResponse> OptionalOptimizationBidOutputMessageList { get; set; }
                public partial class OptionalOptimizationBidOutputMessageListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 可选优化目标出价
                    /// </summary>
                    [JsonPropertyName("optimizationBid")]
                    public long? OptimizationBid { get; set; }

                    /// <summary>
                    /// 可选优化目标
                    /// </summary>
                    [JsonPropertyName("optimizationGoal")]
                    public int? OptimizationGoal { get; set; }

                }

            }

        }

    }

}

