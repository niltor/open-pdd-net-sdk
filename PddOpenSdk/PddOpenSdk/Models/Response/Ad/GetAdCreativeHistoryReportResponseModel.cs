using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdCreativeHistoryReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 开平返回
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 信息列表
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 店铺收藏数
                /// </summary>
                [JsonProperty("mall_fav_num")]
                public long? MallFavNum { get; set; }
                /// <summary>
                /// 千次展现成本
                /// </summary>
                [JsonProperty("cpm")]
                public double? Cpm { get; set; }
                /// <summary>
                /// 广告投资回报率
                /// </summary>
                [JsonProperty("roi")]
                public double? Roi { get; set; }
                /// <summary>
                /// 广告转化支付金额，单位厘
                /// </summary>
                [JsonProperty("gmv")]
                public long? Gmv { get; set; }
                /// <summary>
                /// 广告转化支付订单数
                /// </summary>
                [JsonProperty("order_num")]
                public long? OrderNum { get; set; }
                /// <summary>
                /// 点击单价，单位厘
                /// </summary>
                [JsonProperty("cpc")]
                public double? Cpc { get; set; }
                /// <summary>
                /// 广告消耗,单位厘
                /// </summary>
                [JsonProperty("spend")]
                public long? Spend { get; set; }
                /// <summary>
                /// 广告点击率
                /// </summary>
                [JsonProperty("ctr")]
                public double? Ctr { get; set; }
                /// <summary>
                /// 广告点击数
                /// </summary>
                [JsonProperty("click")]
                public int? Click { get; set; }
                /// <summary>
                /// 广告曝光数
                /// </summary>
                [JsonProperty("impression")]
                public int? Impression { get; set; }
                /// <summary>
                /// 创意状态：1-推广中，2-手动暂停，3-已删除，4-待发布，5-已驳回。 分天数据里无此数据
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 创意ID
                /// </summary>
                [JsonProperty("creative_id")]
                public long? CreativeId { get; set; }
                /// <summary>
                /// 单元ID, 分天数据里无此数据
                /// </summary>
                [JsonProperty("unit_id")]
                public long? UnitId { get; set; }
                /// <summary>
                /// 计划ID,分天数据无此数据
                /// </summary>
                [JsonProperty("plan_id")]
                public long? PlanId { get; set; }
                /// <summary>
                /// 广告主ID
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 分天数据日期，汇总报表无此数据
                /// </summary>
                [JsonProperty("date")]
                public string Date { get; set; }

            }

        }

    }

}
