using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Erp
{
    public partial class GetOrderStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("order_status_get_response")]
        public OrderStatusGetResponseResponseModel OrderStatusGetResponse { get; set; }
        public partial class OrderStatusGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单状态列表对象
            /// </summary>
            [JsonProperty("order_status_list")]
            public List<OrderStatusListResponseModel> OrderStatusList { get; set; }
            public partial class OrderStatusListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 订单编号
                /// </summary>
                [JsonProperty("orderSn")]
                public string Ordersn { get; set; }
                /// <summary>
                /// 订单发货状态，1：待发货，2：已发货待签收，3：已签收 0：异常
                /// </summary>
                [JsonProperty("order_status")]
                public int? OrderStatus { get; set; }
                /// <summary>
                /// 订单售后状态，1：无售后或售后关闭，2：售后处理中，3：退款中，4：退款成功，0：异常
                /// </summary>
                [JsonProperty("refund_status")]
                public int? RefundStatus { get; set; }

            }

        }

    }

}
