using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logistics
{
    public partial class SendLogisticsOnlineRequestModel : PddRequestModel
    {
        /// <summary>
        /// 发货个性内容，支持imei（手机串号），deviceSn（设备序列号），overseaTracing（海淘溯源码id）内容。形如：“imei=识别码1,识别码2;”、“ deviceSn=序列号1,序列号2;”、“overseaTracing=溯源码1,溯源码2;”。以英文逗号“,”分割串号，以英文分号“;”分割不同参数内容。上传时请严格区分imei，deviceSn和overseaTracing，其中overseaTracing（海淘溯源码id）要求海淘商品在支持溯源的情况下必传。错传/漏传将会导致发货失败。
        /// </summary>
        [JsonProperty("feature")]
        public string Feature { get; set; }
        /// <summary>
        /// 快递公司编号
        /// </summary>
        [JsonProperty("logistics_id")]
        public long LogisticsId { get; set; }
        /// <summary>
        /// 订单号。形如：20150909-452750051
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 退货地址的id，不填则取商家默认地址
        /// </summary>
        [JsonProperty("refund_address_id")]
        public string RefundAddressId { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        /// <summary>
        /// 修改发货模式：不传则默认为首次发货 1=首次发货：用于订单首次发货，仅待发货订单可传入； 2=修改发货：用于订单修改发货，调用成功后将会覆盖原发货信息，仅已发货订单可传入
        /// </summary>
        [JsonProperty("redelivery_type")]
        public int? RedeliveryType { get; set; }

    }

}
