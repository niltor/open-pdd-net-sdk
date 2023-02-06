namespace PddOpenSdk.Models.Response.Ad;
public partial class QueryAdApiReportTrHourlyReportResponse : PddResponseModel
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
            /// 小时报表数据列表
            /// </summary>
            [JsonPropertyName("hourlyReportList")]
            public List<HourlyReportListResponse> HourlyReportList { get; set; }

            /// <summary>
            /// 一天的汇总数据
            /// </summary>
            [JsonPropertyName("sumReport")]
            public SumReportResponse SumReport { get; set; }
            public partial class HourlyReportListResponse : PddResponseModel
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
                /// 每笔成交金额
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
                /// 小时：0 ~ 23
                /// </summary>
                [JsonPropertyName("hour")]
                public int? Hour { get; set; }

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

            }
            public partial class SumReportResponse : PddResponseModel
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
                /// 每笔成交金额
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

            }

        }

    }

}

