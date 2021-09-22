using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Order
{
    public partial class GetOrderVirtualInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
