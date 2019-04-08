using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Invoice
{
    public partial class UpdateInvoiceApplicationRequestModel : PddRequestModel {
        /// <summary>
        /// 申请流水号
        /// </summary>
        [JsonProperty ("application_id")]
        public long ApplicationId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty ("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 审核结果：0 = 拒绝，2 = 同意
        /// </summary>
        [JsonProperty ("status")]
        public int Status { get; set; }
        /// <summary>
        /// 驳回原因，status=0必填
        /// </summary>
        [JsonProperty ("reason")]
        public string Reason { get; set; }

    }

}