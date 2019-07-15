using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goodsedit
{
    public partial class QueryGoodsCpsMallUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_cps_mall_unit_query_response")]
        public GoodsCpsMallUnitQueryResponseResponseModel GoodsCpsMallUnitQueryResponse { get; set; }
        public partial class GoodsCpsMallUnitQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 全店推广计划佣金比（千分比）
            /// </summary>
            [JsonProperty("rate")]
            public int? Rate { get; set; }
            /// <summary>
            /// 次日0点生效的全店推广计划佣金比（千分比），若没有则为null
            /// </summary>
            [JsonProperty("rate_to_be")]
            public int? RateToBe { get; set; }
            /// <summary>
            /// 全店推广计划状态：1-推广中，2-暂停推广
            /// </summary>
            [JsonProperty("status")]
            public int? Status { get; set; }
            /// <summary>
            /// 次日0点生效的全店推广计划状态：1-推广中，2-暂停推广，若没有则为null
            /// </summary>
            [JsonProperty("status_to_be")]
            public string StatusToBe { get; set; }

        }

    }

}
