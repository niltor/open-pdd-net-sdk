using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Invoice
{
    public partial class InvalidInvoiceDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
