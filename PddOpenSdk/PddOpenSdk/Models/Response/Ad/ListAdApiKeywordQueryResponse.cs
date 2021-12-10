namespace PddOpenSdk.Models.Response.Ad;
public partial class ListAdApiKeywordQueryResponse : PddResponseModel
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
            /// 出价
            /// </summary>
            [JsonPropertyName("bid")]
            public long? Bid { get; set; }

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
            /// 曝光状态。1表示正常，2表示15天之内无展现。
            /// </summary>
            [JsonPropertyName("impressionStatus")]
            public int? ImpressionStatus { get; set; }

            /// <summary>
            /// 平均推广位置
            /// </summary>
            [JsonPropertyName("keywordAdIdx")]
            public double? KeywordAdIdx { get; set; }

            /// <summary>
            /// 关键词Id
            /// </summary>
            [JsonPropertyName("keywordId")]
            public long? KeywordId { get; set; }

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
            /// 溢价比例。万分比
            /// </summary>
            [JsonPropertyName("premiumRate")]
            public long? PremiumRate { get; set; }

            /// <summary>
            /// 溢价报表
            /// </summary>
            [JsonPropertyName("premiumReportData")]
            public PremiumReportDataResponse PremiumReportData { get; set; }

            /// <summary>
            /// 质量分
            /// </summary>
            [JsonPropertyName("qualityScore")]
            public int? QualityScore { get; set; }

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
            /// 关键词状态。1表示推广中，2表示已删除。
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 转化成本
            /// </summary>
            [JsonPropertyName("transactionCost")]
            public double? TransactionCost { get; set; }

            /// <summary>
            /// 关键词
            /// </summary>
            [JsonPropertyName("word")]
            public string Word { get; set; }
            public partial class PremiumReportDataResponse : PddResponseModel
            {

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
                /// er 千次展现成本
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
                /// 平均推广位置
                /// </summary>
                [JsonPropertyName("keywordAdIdx")]
                public double? KeywordAdIdx { get; set; }

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

            }

        }

    }

}

