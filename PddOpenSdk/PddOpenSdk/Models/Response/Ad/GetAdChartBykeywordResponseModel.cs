using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdChartBykeywordResponseModel : PddResponseModel
    {
        /// <summary>
        /// 数据报表对象
        /// </summary>
        [JsonProperty("keyword_daily_report_list")]
        public KeywordDailyReportListResponseModel KeywordDailyReportList { get; set; }
        public partial class KeywordDailyReportListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单数据
            /// </summary>
            [JsonProperty("conversion")]
            public ConversionResponseModel Conversion { get; set; }
            /// <summary>
            /// 返回的关键词报表总条数
            /// </summary>
            [JsonProperty("total_count")]
            public object TotalCount { get; set; }
            /// <summary>
            /// 日期
            /// </summary>
            [JsonProperty("date")]
            public string Date { get; set; }
            /// <summary>
            /// 计划信息
            /// </summary>
            [JsonProperty("ad_info")]
            public AdInfoResponseModel AdInfo { get; set; }
            /// <summary>
            /// 点击量数据
            /// </summary>
            [JsonProperty("click_num")]
            public int ClickNum { get; set; }
            /// <summary>
            /// 展现量数据
            /// </summary>
            [JsonProperty("impression_num")]
            public int ImpressionNum { get; set; }
            /// <summary>
            /// 广告花费，单位为分
            /// </summary>
            [JsonProperty("spend")]
            public int Spend { get; set; }
            public partial class ConversionResponseModel : PddResponseModel
            {
                /// <summary>
                /// 总推广订单数
                /// </summary>
                [JsonProperty("total_order_num")]
                public int TotalOrderNum { get; set; }
                /// <summary>
                /// 总推广订单金额
                /// </summary>
                [JsonProperty("total_order_gmv")]
                public int TotalOrderGmv { get; set; }
                /// <summary>
                /// 直接发生购买转化的订单总销售金额，单位为分
                /// </summary>
                [JsonProperty("direct_gmv")]
                public object DirectGmv { get; set; }
                /// <summary>
                /// 直接发生购买转化的订单数
                /// </summary>
                [JsonProperty("direct_order_num")]
                public int DirectOrderNum { get; set; }

            }
            public partial class AdInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 推广计划名称
                /// </summary>
                [JsonProperty("plan_name")]
                public string PlanName { get; set; }
                /// <summary>
                /// 推广计划中的关键词
                /// </summary>
                [JsonProperty("keyword")]
                public string Keyword { get; set; }

            }

        }

    }

}
