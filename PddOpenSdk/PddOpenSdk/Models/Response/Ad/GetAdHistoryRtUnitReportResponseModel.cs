using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdHistoryRtUnitReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_real_time_report_response")]
        public AdUnitRealTimeReportResponseResponseModel AdUnitRealTimeReportResponse { get; set; }
        public partial class AdUnitRealTimeReportResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 报表对象列表
            /// </summary>
            [JsonProperty("unit_real_time_report_list")]
            public List<UnitRealTimeReportListResponseModel> UnitRealTimeReportList { get; set; }
            public partial class UnitRealTimeReportListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 单元状态。1表示推广中，2表示手动暂停，3表示商品售罄，4表示商品下架，5表示限制推广，6表示已删除，7表示审核中，8表示无推广中创意，9表示审核驳回，10表示品牌词重审驳回
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 计划id
                /// </summary>
                [JsonProperty("plan_id")]
                public long? PlanId { get; set; }
                /// <summary>
                /// 单元id
                /// </summary>
                [JsonProperty("unit_id")]
                public long? UnitId { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 1：已启用，2：未启用
                /// </summary>
                [JsonProperty("operate_status")]
                public int? OperateStatus { get; set; }
                /// <summary>
                /// 商品名
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品图片url
                /// </summary>
                [JsonProperty("thumb_url")]
                public string ThumbUrl { get; set; }
                /// <summary>
                /// 最小团购价
                /// </summary>
                [JsonProperty("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 最大团购价
                /// </summary>
                [JsonProperty("max_group_price")]
                public long? MaxGroupPrice { get; set; }
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
