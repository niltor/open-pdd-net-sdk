namespace PddOpenSdk.Models.Response.Ad;
public partial class InfoAdApiUnitTrListAdResponse : PddResponseModel
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
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 商品全站推广信息列表
            /// </summary>
            [JsonPropertyName("adInfos")]
            public List<AdInfosResponse> AdInfos { get; set; }

            /// <summary>
            /// 列表总数
            /// </summary>
            [JsonPropertyName("totalAdNum")]
            public int? TotalAdNum { get; set; }
            public partial class AdInfosResponse : PddResponseModel
            {

                /// <summary>
                /// 单元名称
                /// </summary>
                [JsonPropertyName("adName")]
                public string AdName { get; set; }

                /// <summary>
                /// 广告状态
                /// </summary>
                [JsonPropertyName("adStatus")]
                public int? AdStatus { get; set; }

                /// <summary>
                /// 审核驳回原因
                /// </summary>
                [JsonPropertyName("auditRefusedReason")]
                public string AuditRefusedReason { get; set; }

                /// <summary>
                /// 出价类型 1-目标roi 2-成交出价
                /// </summary>
                [JsonPropertyName("bidType")]
                public int? BidType { get; set; }

                /// <summary>
                /// 数据积累期
                /// </summary>
                [JsonPropertyName("dataAccumulationStatus")]
                public int? DataAccumulationStatus { get; set; }

                /// <summary>
                /// 计划状态
                /// </summary>
                [JsonPropertyName("dataOperateStatus")]
                public int? DataOperateStatus { get; set; }

                /// <summary>
                /// 商品id
                /// </summary>
                [JsonPropertyName("goodsId")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goodsName")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonPropertyName("mallId")]
                public long? MallId { get; set; }

                /// <summary>
                /// 日限额
                /// </summary>
                [JsonPropertyName("maxCost")]
                public long? MaxCost { get; set; }

                /// <summary>
                /// 最小团购价
                /// </summary>
                [JsonPropertyName("minGroupPrice")]
                public long? MinGroupPrice { get; set; }

                /// <summary>
                /// 成交出价
                /// </summary>
                [JsonPropertyName("optimizationBid")]
                public long? OptimizationBid { get; set; }

                /// <summary>
                /// 广告报表信息
                /// </summary>
                [JsonPropertyName("reportInfo")]
                public ReportInfoResponse ReportInfo { get; set; }

                /// <summary>
                /// 广告限制原因
                /// </summary>
                [JsonPropertyName("restrictionReason")]
                public string RestrictionReason { get; set; }

                /// <summary>
                /// 目标roi
                /// </summary>
                [JsonPropertyName("targetRoi")]
                public long? TargetRoi { get; set; }

                /// <summary>
                /// 商品图片
                /// </summary>
                [JsonPropertyName("thumbUrl")]
                public string ThumbUrl { get; set; }
                public partial class ReportInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 直接成交每笔成交金额，单位厘
                    /// </summary>
                    [JsonPropertyName("avgDirectPayAmount")]
                    public double? AvgDirectPayAmount { get; set; }

                    /// <summary>
                    /// 间接成交每笔成交金额，单位厘
                    /// </summary>
                    [JsonPropertyName("avgIndirectPayAmount")]
                    public double? AvgIndirectPayAmount { get; set; }

                    /// <summary>
                    /// 每笔成交金额(average pay amount)，单位厘
                    /// </summary>
                    [JsonPropertyName("avgPayAmount")]
                    public double? AvgPayAmount { get; set; }

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
                    /// 直接成交交易额，单位厘
                    /// </summary>
                    [JsonPropertyName("directGmv")]
                    public long? DirectGmv { get; set; }

                    /// <summary>
                    /// 直接成交笔数
                    /// </summary>
                    [JsonPropertyName("directOrderNum")]
                    public long? DirectOrderNum { get; set; }

                    /// <summary>
                    /// 全站费比 spend / globalGmv
                    /// </summary>
                    [JsonPropertyName("globalTakeRate")]
                    public double? GlobalTakeRate { get; set; }

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
                    /// 间接成交交易额，单位厘
                    /// </summary>
                    [JsonPropertyName("indirectGmv")]
                    public long? IndirectGmv { get; set; }

                    /// <summary>
                    /// 间接成交笔数
                    /// </summary>
                    [JsonPropertyName("indirectOrderNum")]
                    public long? IndirectOrderNum { get; set; }

                    /// <summary>
                    /// 店铺收藏数
                    /// </summary>
                    [JsonPropertyName("mallFavNum")]
                    public long? MallFavNum { get; set; }

                    /// <summary>
                    /// 广告转化支付订单量
                    /// </summary>
                    [JsonPropertyName("orderNum")]
                    public long? OrderNum { get; set; }

                    /// <summary>
                    /// 广告排名（平均数）
                    /// </summary>
                    [JsonPropertyName("rankAverage")]
                    public double? RankAverage { get; set; }

                    /// <summary>
                    /// 广告排名（中位数）
                    /// </summary>
                    [JsonPropertyName("rankMedian")]
                    public double? RankMedian { get; set; }

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
                    /// 转化成本
                    /// </summary>
                    [JsonPropertyName("transactionCost")]
                    public double? TransactionCost { get; set; }

                    /// <summary>
                    /// 广告 UV
                    /// </summary>
                    [JsonPropertyName("uniqueView")]
                    public long? UniqueView { get; set; }

                }

            }

        }

    }

}

