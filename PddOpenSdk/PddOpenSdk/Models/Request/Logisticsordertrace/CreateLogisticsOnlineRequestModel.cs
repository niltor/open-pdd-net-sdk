using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logisticsordertrace
{
    public partial class CreateLogisticsOnlineRequestModel : PddRequestModel
    {
        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        /// <summary>
        /// 物流公司id
        /// </summary>
        [JsonProperty("shipping_id")]
        public int ShippingId { get; set; }
        /// <summary>
        /// refund_address_id 通过pdd.refund.address.list.get 这个接口获取
        /// </summary>
        [JsonProperty("return_id")]
        public string ReturnId { get; set; }
        /// <summary>
        /// 发货人电话
        /// </summary>
        [JsonProperty("delivery_phone")]
        public string DeliveryPhone { get; set; }
        /// <summary>
        /// 发货人姓名
        /// </summary>
        [JsonProperty("delivery_name")]
        public string DeliveryName { get; set; }
        /// <summary>
        /// 发货人地址
        /// </summary>
        [JsonProperty("delivery_address")]
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// 发货人地址id
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
