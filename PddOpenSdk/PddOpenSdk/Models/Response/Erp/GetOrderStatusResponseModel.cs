using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public class OrderStatusList
    {

        /// <summary>
        /// Examples: "171219-496576280321088"
        /// </summary>
        [JsonProperty("orderSn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("refund_status")]
        public int RefundStatus { get; set; }
    }

    public class OrderStatusGetResponse
    {

        /// <summary>
        /// Examples: [{"orderSn":"171219-496576280321088","order_status":2,"refund_status":1}]
        /// </summary>
        [JsonProperty("order_status_list")]
        public IList<OrderStatusList> OrderStatusList { get; set; }
    }

    public class GetOrderStatusResponseModel
    {

        /// <summary>
        /// Examples: {"order_status_list":[{"orderSn":"171219-496576280321088","order_status":2,"refund_status":1}]}
        /// </summary>
        [JsonProperty("order_status_get_response")]
        public OrderStatusGetResponse OrderStatusGetResponse { get; set; }
    }


}
