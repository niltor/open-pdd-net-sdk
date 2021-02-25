using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdApiKeywordQueryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 每笔成交金额(average pay amount)，单位厘
                /// </summary>
                [JsonProperty("avgPayAmount")]
                public double? AvgPayAmount { get; set; }
                /// <summary>
                /// 出价
                /// </summary>
                [JsonProperty("bid")]
                public long? Bid { get; set; }
                /// <summary>
                /// 广告点击量
                /// </summary>
                [JsonProperty("click")]
                public long? Click { get; set; }
                /// <summary>
                /// 平均点击花费，单位厘
                /// </summary>
                [JsonProperty("cpc")]
                public double? Cpc { get; set; }
                /// <summary>
                /// 千次展现成本
                /// </summary>
                [JsonProperty("cpm")]
                public double? Cpm { get; set; }
                /// <summary>
                /// 广告点击率
                /// </summary>
                [JsonProperty("ctr")]
                public double? Ctr { get; set; }
                /// <summary>
                /// 点击转化率
                /// </summary>
                [JsonProperty("cvr")]
                public double? Cvr { get; set; }
                /// <summary>
                /// 广告转化支付金额，单位厘
                /// </summary>
                [JsonProperty("gmv")]
                public long? Gmv { get; set; }
                /// <summary>
                /// 商品收藏数
                /// </summary>
                [JsonProperty("goodsFavNum")]
                public long? GoodsFavNum { get; set; }
                /// <summary>
                /// 广告曝光量
                /// </summary>
                [JsonProperty("impression")]
                public long? Impression { get; set; }
                /// <summary>
                /// 曝光状态。1表示正常，2表示15天之内无展现。
                /// </summary>
                [JsonProperty("impressionStatus")]
                public int? ImpressionStatus { get; set; }
                /// <summary>
                /// 平均推广位置
                /// </summary>
                [JsonProperty("keywordAdIdx")]
                public double? KeywordAdIdx { get; set; }
                /// <summary>
                /// 关键词Id
                /// </summary>
                [JsonProperty("keywordId")]
                public long? KeywordId { get; set; }
                /// <summary>
                /// 店铺收藏数
                /// </summary>
                [JsonProperty("mallFavNum")]
                public long? MallFavNum { get; set; }
                /// <summary>
                /// 广告转化支付订单量
                /// </summary>
                [JsonProperty("orderNum")]
                public long? OrderNum { get; set; }
                /// <summary>
                /// 溢价比例。万分比
                /// </summary>
                [JsonProperty("premiumRate")]
                public long? PremiumRate { get; set; }
                /// <summary>
                /// 溢价报表
                /// </summary>
                [JsonProperty("premiumReportData")]
                public PremiumReportDataResponseModel PremiumReportData { get; set; }
                /// <summary>
                /// 质量分
                /// </summary>
                [JsonProperty("qualityScore")]
                public int? QualityScore { get; set; }
                /// <summary>
                /// 广告排名（平均数）
                /// </summary>
                [JsonProperty("rankAverage")]
                public double? RankAverage { get; set; }
                /// <summary>
                /// 广告排名（中位数）
                /// </summary>
                [JsonProperty("rankMedian")]
                public double? RankMedian { get; set; }
                /// <summary>
                /// 广告投入产出比
                /// </summary>
                [JsonProperty("roi")]
                public double? Roi { get; set; }
                /// <summary>
                /// 广告消耗,单位厘
                /// </summary>
                [JsonProperty("spend")]
                public long? Spend { get; set; }
                /// <summary>
                /// 关键词状态。1表示推广中，2表示已删除。
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 转化成本
                /// </summary>
                [JsonProperty("transactionCost")]
                public double? TransactionCost { get; set; }
                /// <summary>
                /// 关键词
                /// </summary>
                [JsonProperty("word")]
                public string Word { get; set; }
                public partial class PremiumReportDataResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 每笔成交金额(average pay amount)，单位厘
                    /// </summary>
                    [JsonProperty("avgPayAmount")]
                    public double? AvgPayAmount { get; set; }
                    /// <summary>
                    /// 广告点击量
                    /// </summary>
                    [JsonProperty("click")]
                    public long? Click { get; set; }
                    /// <summary>
                    /// 平均点击花费，单位厘
                    /// </summary>
                    [JsonProperty("cpc")]
                    public double? Cpc { get; set; }
                    /// <summary>
                    /// er 千次展现成本
                    /// </summary>
                    [JsonProperty("cpm")]
                    public double? Cpm { get; set; }
                    /// <summary>
                    /// 广告点击率
                    /// </summary>
                    [JsonProperty("ctr")]
                    public double? Ctr { get; set; }
                    /// <summary>
                    /// 点击转化率
                    /// </summary>
                    [JsonProperty("cvr")]
                    public double? Cvr { get; set; }
                    /// <summary>
                    /// 广告转化支付金额，单位厘
                    /// </summary>
                    [JsonProperty("gmv")]
                    public long? Gmv { get; set; }
                    /// <summary>
                    /// 商品收藏数
                    /// </summary>
                    [JsonProperty("goodsFavNum")]
                    public long? GoodsFavNum { get; set; }
                    /// <summary>
                    /// 广告曝光量
                    /// </summary>
                    [JsonProperty("impression")]
                    public long? Impression { get; set; }
                    /// <summary>
                    /// 平均推广位置
                    /// </summary>
                    [JsonProperty("keywordAdIdx")]
                    public double? KeywordAdIdx { get; set; }
                    /// <summary>
                    /// 店铺收藏数
                    /// </summary>
                    [JsonProperty("mallFavNum")]
                    public long? MallFavNum { get; set; }
                    /// <summary>
                    /// 广告转化支付订单量
                    /// </summary>
                    [JsonProperty("orderNum")]
                    public long? OrderNum { get; set; }
                    /// <summary>
                    /// 广告排名（平均数）
                    /// </summary>
                    [JsonProperty("rankAverage")]
                    public double? RankAverage { get; set; }
                    /// <summary>
                    /// 广告排名（中位数）
                    /// </summary>
                    [JsonProperty("rankMedian")]
                    public double? RankMedian { get; set; }
                    /// <summary>
                    /// 广告投入产出比
                    /// </summary>
                    [JsonProperty("roi")]
                    public double? Roi { get; set; }
                    /// <summary>
                    /// 广告消耗,单位厘
                    /// </summary>
                    [JsonProperty("spend")]
                    public long? Spend { get; set; }
                    /// <summary>
                    /// 转化成本
                    /// </summary>
                    [JsonProperty("transactionCost")]
                    public double? TransactionCost { get; set; }

                }

            }

        }

    }

}
