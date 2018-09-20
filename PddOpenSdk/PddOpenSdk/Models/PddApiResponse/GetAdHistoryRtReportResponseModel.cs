using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("ad_mall_real_time_report_response")]
        public AdMallRealTimeReportResponseResponseModel AdMallRealTimeReportResponse { get; set; }

        public partial class AdMallRealTimeReportResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 广告曝光数
            /// </summary>
            [JsonProperty("ad_impr_num")]
            public int AdImprNum { get; set; }
            /// <summary>
            /// 广告点击数
            /// </summary>
            [JsonProperty("ad_clk_num")]
            public int AdClkNum { get; set; }
            /// <summary>
            /// 广告消耗
            /// </summary>
            [JsonProperty("spend")]
            public int Spend { get; set; }
            /// <summary>
            /// 广告转化支付订单数
            /// </summary>
            [JsonProperty("pay_order_num")]
            public int PayOrderNum { get; set; }
            /// <summary>
            /// 广告转化支付金额
            /// </summary>
            [JsonProperty("pay_gmv")]
            public int PayGmv { get; set; }
            /// <summary>
            /// 投入产出比
            /// </summary>
            [JsonProperty("roi")]
            public object Roi { get; set; }
            /// <summary>
            /// 点击率
            /// </summary>
            [JsonProperty("clickRate")]
            public object Clickrate { get; set; }

        }

    }
}
