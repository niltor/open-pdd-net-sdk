using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class QueryDdkFinanceCpaResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("finance_cpa_query_response")]
        public FinanceCpaQueryResponseResponseModel FinanceCpaQueryResponse { get; set; }
        public partial class FinanceCpaQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// CPA补贴并锁佣数量，支持T+1查询
            /// </summary>
            [JsonProperty("cpa_new_num")]
            public int? CpaNewNum { get; set; }
            /// <summary>
            /// 质量分（以天为维度，支持T+8查询；查询duoid维度返回具体数值，查询pid维度返回高中低）
            /// </summary>
            [JsonProperty("quality_score")]
            public string QualityScore { get; set; }
            /// <summary>
            /// 预估补贴（单位分，以天为维度，支持T+8查询；查询duoid维度返回具体数值，查询pid维度返回空）
            /// </summary>
            [JsonProperty("subsidy_fee")]
            public int? SubsidyFee { get; set; }

        }

    }

}
