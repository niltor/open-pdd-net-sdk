namespace PddOpenSdk.Models.Request.Refund;
public partial class ShippingRefundExchange
{

    /// <summary>
    /// request
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 售后id
        /// </summary>
        [JsonPropertyName("after_sales_id")]
        public long AfterSalesId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 物流公司id
        /// </summary>
        [JsonPropertyName("shipping_id")]
        public int ShippingId { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("shipping_name")]
        public string ShippingName { get; set; }

        /// <summary>
        /// 换货物流单号
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

    }

}

