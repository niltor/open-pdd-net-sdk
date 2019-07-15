using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Financebalance
{
    public partial class GetFinanceBalanceDailyBillUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 账单日期（形如yyyy-MM-dd）；例如入参为“2019-03-24”，则返回2019年3月24日的商家货款日账单的下载链接
        /// </summary>
        [JsonProperty("bill_date")]
        public string BillDate { get; set; }

    }

}
