using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Oversea
{
    public partial class GetOverseaClearanceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
