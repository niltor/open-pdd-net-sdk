namespace PddOpenSdk.Models.Response.ServiceMarket;
public partial class GetServicemarketSettlementbillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("settlement_bill_search_response")]
    public SettlementBillSearchResponseResponse SettlementBillSearchResponse { get; set; }
    public partial class SettlementBillSearchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 结算明细列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<DataResponse> Data { get; set; }

        /// <summary>
        /// 当前查询条件下所有订单总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class DataResponse : PddResponseModel
        {

            /// <summary>
            /// 服务订单号
            /// </summary>
            [JsonPropertyName("service_order_sn")]
            public string ServiceOrderSn { get; set; }

            /// <summary>
            /// 当期结算金额，单位分
            /// </summary>
            [JsonPropertyName("settle_amount")]
            public long? SettleAmount { get; set; }

            /// <summary>
            /// 结算月份
            /// </summary>
            [JsonPropertyName("settle_month")]
            public string SettleMonth { get; set; }

            /// <summary>
            /// 结算时间
            /// </summary>
            [JsonPropertyName("settle_time")]
            public string SettleTime { get; set; }

            /// <summary>
            /// 待结算金额，单位分
            /// </summary>
            [JsonPropertyName("unsettle_amount")]
            public long? UnsettleAmount { get; set; }

            /// <summary>
            /// 服务名称
            /// </summary>
            [JsonPropertyName("service_name")]
            public string ServiceName { get; set; }

            /// <summary>
            /// 订单类型：0-应用服务、1-客服外包、2-电子发票、3-店铺装修、4-推广托管、5-代运营服务
            /// </summary>
            [JsonPropertyName("order_type")]
            public int? OrderType { get; set; }

        }

    }

}

