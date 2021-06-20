using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Refund
{
    public partial class ShippingRefundExchangeRequestModel : PddRequestModel
    {
        /// <summary>
        /// request
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 售后id
            /// </summary>
            [JsonProperty("after_sales_id")]
            public long AfterSalesId { get; set; }
            /// <summary>
            /// 订单编号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }
            /// <summary>
            /// 物流公司id
            /// </summary>
            [JsonProperty("shipping_id")]
            public int ShippingId { get; set; }
            /// <summary>
            /// 物流公司名称
            /// </summary>
            [JsonProperty("shipping_name")]
            public string ShippingName { get; set; }
            /// <summary>
            /// 换货物流单号
            /// </summary>
            [JsonProperty("tracking_number")]
            public string TrackingNumber { get; set; }

        }

    }

}
