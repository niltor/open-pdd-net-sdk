using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.ServiceMarket
{
    public partial class GetServicemarketSettlementbillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("settlement_bill_search_response")]
        public SettlementBillSearchResponseResponseModel SettlementBillSearchResponse { get; set; }
        public partial class SettlementBillSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 结算明细列表
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
                /// 服务订单号
                /// </summary>
                [JsonProperty("service_order_sn")]
                public string ServiceOrderSn { get; set; }
                /// <summary>
                /// 当期结算金额，单位分
                /// </summary>
                [JsonProperty("settle_amount")]
                public long? SettleAmount { get; set; }
                /// <summary>
                /// 结算月份
                /// </summary>
                [JsonProperty("settle_month")]
                public string SettleMonth { get; set; }
                /// <summary>
                /// 结算时间
                /// </summary>
                [JsonProperty("settle_time")]
                public string SettleTime { get; set; }
                /// <summary>
                /// 待结算金额，单位分
                /// </summary>
                [JsonProperty("unsettle_amount")]
                public long? UnsettleAmount { get; set; }
                /// <summary>
                /// 服务名称
                /// </summary>
                [JsonProperty("service_name")]
                public string ServiceName { get; set; }
                /// <summary>
                /// 订单类型：0-应用服务、1-客服外包、2-电子发票、3-店铺装修、4-推广托管、5-代运营服务
                /// </summary>
                [JsonProperty("order_type")]
                public int? OrderType { get; set; }

            }

        }

    }

}
