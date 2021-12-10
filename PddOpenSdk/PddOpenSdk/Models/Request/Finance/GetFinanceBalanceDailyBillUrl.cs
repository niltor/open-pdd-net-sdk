namespace PddOpenSdk.Models.Request.Finance;
public partial class GetFinanceBalanceDailyBillUrl
{

    /// <summary>
    /// 账单日期（形如yyyy-MM-dd）；例如入参为“2019-03-24”，则返回2019年3月24日的商家货款日账单的下载链接
    /// </summary>
    [JsonPropertyName("bill_date")]
    public string BillDate { get; set; }

}

