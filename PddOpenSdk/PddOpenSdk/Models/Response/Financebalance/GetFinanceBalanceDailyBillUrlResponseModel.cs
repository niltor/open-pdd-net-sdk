using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Financebalance
{
    public partial class GetFinanceBalanceDailyBillUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("finance_balance_daily_bill_url_get_response")]
        public FinanceBalanceDailyBillUrlGetResponseResponseModel FinanceBalanceDailyBillUrlGetResponse { get; set; }
        public partial class FinanceBalanceDailyBillUrlGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 下载url
            /// </summary>
            [JsonProperty("download_url")]
            public string DownloadUrl { get; set; }

        }

    }

}
