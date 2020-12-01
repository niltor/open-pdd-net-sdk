using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class QueryAdApiReportEntityReportResponseModel : PddResponseModel
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
            public ResultResponseModel Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 单页报表数据列表
                /// </summary>
                [JsonProperty("entityReportList")]
                public List<EntityReportListResponseModel> EntityReportList { get; set; }
                /// <summary>
                /// 分页数据汇总
                /// </summary>
                [JsonProperty("sumReport")]
                public SumReportResponseModel SumReport { get; set; }
                /// <summary>
                /// 报表记录总数
                /// </summary>
                [JsonProperty("total")]
                public long? Total { get; set; }
                public partial class EntityReportListResponseModel : PddResponseModel
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
                    /// 查询的维度
                    /// </summary>
                    [JsonProperty("dimensionType")]
                    public int? DimensionType { get; set; }
                    /// <summary>
                    /// 查询维度的主体id
                    /// </summary>
                    [JsonProperty("entityId")]
                    public long? EntityId { get; set; }
                    /// <summary>
                    /// 业务数据说明
                    /// </summary>
                    [JsonProperty("externalFieldValues")]
                    public Dictionary<string, object> ExternalFieldValues { get; set; }
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
                    public partial class ExternalFieldValuesResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// key
                        /// </summary>
                        [JsonProperty("$key")]
                        public string Key { get; set; }
                        /// <summary>
                        /// value
                        /// </summary>
                        [JsonProperty("$value")]
                        public string Value { get; set; }

                    }

                }
                public partial class SumReportResponseModel : PddResponseModel
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
