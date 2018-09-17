using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CheckRefundStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.refund.status.check
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 20150909-452750051,20150909-452750134 用逗号分开
        /// </summary>
        [JsonProperty("order_sns")]
        public object OrderSns { get; set; }

    }
}
