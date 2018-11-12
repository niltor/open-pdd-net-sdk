using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdHistoryRtKeywordReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_real_time_report_response")]
        public AdKeywordRealTimeReportResponseResponseModel AdKeywordRealTimeReportResponse { get; set; }
        public partial class AdKeywordRealTimeReportResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// report列表
            /// </summary>
            [JsonProperty("keyword_real_time_report_list")]
            public List<KeywordRealTimeReportListResponseModel> KeywordRealTimeReportList { get; set; }
            public partial class KeywordRealTimeReportListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 关键词id
                /// </summary>
                [JsonProperty("keyword_id")]
                public long? KeywordId { get; set; }
                /// <summary>
                /// 关键词
                /// </summary>
                [JsonProperty("word")]
                public string Word { get; set; }
                /// <summary>
                /// 出价
                /// </summary>
                [JsonProperty("bid")]
                public long? Bid { get; set; }
                /// <summary>
                /// 关键词状态 1-推广中 2-已删除
                /// </summary>
                [JsonProperty("impression_status")]
                public int? ImpressionStatus { get; set; }
                /// <summary>
                /// 质量分
                /// </summary>
                [JsonProperty("quality_score")]
                public long? QualityScore { get; set; }
                /// <summary>
                /// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 广告投资回报率
                /// </summary>
                [JsonProperty("roi")]
                public double? Roi { get; set; }
                /// <summary>
                /// 千次展现成本
                /// </summary>
                [JsonProperty("cpm")]
                public double? Cpm { get; set; }
                /// <summary>
                /// 广告曝光数
                /// </summary>
                [JsonProperty("impression")]
                public long? Impression { get; set; }
                /// <summary>
                /// 广告点击数
                /// </summary>
                [JsonProperty("click")]
                public long? Click { get; set; }
                /// <summary>
                /// 广告点击率
                /// </summary>
                [JsonProperty("ctr")]
                public double? Ctr { get; set; }
                /// <summary>
                /// 广告消耗,单位厘
                /// </summary>
                [JsonProperty("spend")]
                public long? Spend { get; set; }
                /// <summary>
                /// 点击单价，单位厘
                /// </summary>
                [JsonProperty("cpc")]
                public double? Cpc { get; set; }
                /// <summary>
                /// 广告转化支付订单数
                /// </summary>
                [JsonProperty("order_num")]
                public long? OrderNum { get; set; }
                /// <summary>
                /// 广告转化支付金额，单位厘
                /// </summary>
                [JsonProperty("gmv")]
                public long? Gmv { get; set; }
                /// <summary>
                /// 日期
                /// </summary>
                [JsonProperty("date")]
                public string Date { get; set; }

            }

        }

    }

}
