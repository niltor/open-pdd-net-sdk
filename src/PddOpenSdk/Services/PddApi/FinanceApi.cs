
using PddOpenSdk.Models.Request.Finance;
using PddOpenSdk.Models.Response.Finance;

namespace PddOpenSdk.Services.PddApi;
public class FinanceApi : PddCommonApi
{
    public FinanceApi() { }
    public FinanceApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 商家货款日账单下载链接查询接口
    /// </summary>
    public async Task<GetFinanceBalanceDailyBillUrlResponse> GetFinanceBalanceDailyBillUrlAsync(GetFinanceBalanceDailyBillUrl getFinanceBalanceDailyBillUrl)
    {
        var result = await PostAsync<GetFinanceBalanceDailyBillUrl, GetFinanceBalanceDailyBillUrlResponse>("pdd.finance.balance.daily.bill.url.get", getFinanceBalanceDailyBillUrl);
        return result;
    }

}
