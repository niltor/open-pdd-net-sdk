using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Erp
{
    public partial class GetOrderInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
