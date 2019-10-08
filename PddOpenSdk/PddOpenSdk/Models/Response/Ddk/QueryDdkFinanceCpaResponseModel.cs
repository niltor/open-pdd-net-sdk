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
            /// CPA补贴并锁佣数量
            /// </summary>
            [JsonProperty("cpa_new_num")]
            public int? CpaNewNum { get; set; }
            /// <summary>
            /// CPA锁佣数量
            /// </summary>
            [JsonProperty("cpa_old_num")]
            public int? CpaOldNum { get; set; }
            /// <summary>
            /// 预估补贴，单位分
            /// </summary>
            [JsonProperty("subsidy_fee")]
            public int? SubsidyFee { get; set; }
            /// <summary>
            /// 首单数
            /// </summary>
            [JsonProperty("order_num")]
            public long? OrderNum { get; set; }

        }

    }

}
