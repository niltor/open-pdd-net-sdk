using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdHistoryUnitReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_history_report_get_response")]
        public AdUnitHistoryReportGetResponseResponseModel AdUnitHistoryReportGetResponse { get; set; }
        public partial class AdUnitHistoryReportGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
            /// <summary>
            /// report列表
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 扩展字段
                /// </summary>
                [JsonProperty("external_fields")]
                public Dictionary<string, object> ExternalFields { get; set; }
                /// <summary>
                /// 广告投资回报率
                /// </summary>
                [JsonProperty("roi")]
                public double? Roi { get; set; }
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
