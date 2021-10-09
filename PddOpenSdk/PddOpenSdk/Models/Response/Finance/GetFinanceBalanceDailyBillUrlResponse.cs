namespace PddOpenSdk.Models.Response.Finance;
public partial class GetFinanceBalanceDailyBillUrlResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("finance_balance_daily_bill_url_get_response")]
    public FinanceBalanceDailyBillUrlGetResponseResponse FinanceBalanceDailyBillUrlGetResponse { get; set; }
    public partial class FinanceBalanceDailyBillUrlGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 货款账单下载 URL
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

    }

}

