namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderStatusResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("order_status_get_response")]
    public OrderStatusGetResponseResponse OrderStatusGetResponse { get; set; }
    public partial class OrderStatusGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 订单状态列表对象
        /// </summary>
        [JsonPropertyName("order_status_list")]
        public List<OrderStatusListResponse> OrderStatusList { get; set; }
        public partial class OrderStatusListResponse : PddResponseModel
        {

            /// <summary>
            /// 订单编号
            /// </summary>
            [JsonPropertyName("orderSn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 订单发货状态，1：待发货，2：已发货待签收，3：已签收 0：异常
            /// </summary>
            [JsonPropertyName("order_status")]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// 订单售后状态，1：无售后或售后关闭，2：售后处理中，3：退款中，4：退款成功，0：异常
            /// </summary>
            [JsonPropertyName("refund_status")]
            public int? RefundStatus { get; set; }

        }

    }

}

