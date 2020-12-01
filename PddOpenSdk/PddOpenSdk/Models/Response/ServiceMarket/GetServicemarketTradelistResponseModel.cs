using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.ServiceMarket
{
    public partial class GetServicemarketTradelistResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("mall_balance_flow_search_response")]
        public MallBalanceFlowSearchResponseResponseModel MallBalanceFlowSearchResponse { get; set; }
        public partial class MallBalanceFlowSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 交易流水列表
            /// </summary>
            [JsonProperty("data")]
            public List<DataResponseModel> Data { get; set; }
            /// <summary>
            /// 当前查询条件下所有订单总数
            /// </summary>
            [JsonProperty("total_count")]
            public int? TotalCount { get; set; }
            public partial class DataResponseModel : PddResponseModel
            {
                /// <summary>
                /// 交易金额，单位分
                /// </summary>
                [JsonProperty("amount")]
                public long? Amount { get; set; }
                /// <summary>
                /// 流水类目名称，1-交易收入，2-优惠券结算，3-退款，4-提现，5-技术服务费，7-扣款
                /// </summary>
                [JsonProperty("class_name")]
                public string ClassName { get; set; }
                /// <summary>
                /// 流水创建时间，单位秒
                /// </summary>
                [JsonProperty("created_at")]
                public int? CreatedAt { get; set; }
                /// <summary>
                /// 交易流水号
                /// </summary>
                [JsonProperty("flow_id")]
                public long? FlowId { get; set; }
                /// <summary>
                /// 资金流向，1-收入，2-支出
                /// </summary>
                [JsonProperty("group_type")]
                public int? GroupType { get; set; }
                /// <summary>
                /// 服务订单号
                /// </summary>
                [JsonProperty("service_order_sn")]
                public string ServiceOrderSn { get; set; }
                /// <summary>
                /// 交易备注
                /// </summary>
                [JsonProperty("trade_note")]
                public string TradeNote { get; set; }

            }

        }

    }

}
