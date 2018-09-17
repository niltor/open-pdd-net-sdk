using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class QueryInvoiceDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }
        /// <summary>
        /// 发票流水号
        /// </summary>
        [JsonProperty("serial_no")]
        public object SerialNo { get; set; }

    }
}
