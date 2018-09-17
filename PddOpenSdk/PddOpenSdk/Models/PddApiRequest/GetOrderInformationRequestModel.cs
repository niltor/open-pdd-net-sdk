using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetOrderInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.order.information.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }

    }
}
