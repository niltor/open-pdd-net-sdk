namespace PddOpenSdk.Models.Response.Order;
public partial class CheckRefundStatusResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("refund_status_check_response")]
    public RefundStatusCheckResponseResponse RefundStatusCheckResponse { get; set; }
    public partial class RefundStatusCheckResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 存在售后的订单
        /// </summary>
        [JsonPropertyName("order_sns_exists_refund")]
        public List<OrderSnsExistsRefundResponse> OrderSnsExistsRefund { get; set; }
        public partial class OrderSnsExistsRefundResponse : PddResponseModel
        {

            /// <summary>
            /// 订单编号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

        }

    }

}

