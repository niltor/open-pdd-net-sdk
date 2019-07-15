using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Refundstatus
{
    public partial class CheckRefundStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 20150909-452750051,20150909-452750134 用逗号分开
        /// </summary>
        [JsonProperty("order_sns")]
        public string OrderSns { get; set; }

    }

}
