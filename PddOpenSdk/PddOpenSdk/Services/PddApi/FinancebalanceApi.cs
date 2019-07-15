using PddOpenSdk.Models.Request.Financebalance;
using PddOpenSdk.Models.Response.Financebalance;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class FinancebalanceApi : PddCommonApi
    {
        /// <summary>
        /// 商家货款日账单下载链接查询接口
        /// </summary>
        public async Task<GetFinanceBalanceDailyBillUrlResponseModel> GetFinanceBalanceDailyBillUrlAsync(GetFinanceBalanceDailyBillUrlRequestModel getFinanceBalanceDailyBillUrl)
        {
            var result = await PostAsync<GetFinanceBalanceDailyBillUrlRequestModel, GetFinanceBalanceDailyBillUrlResponseModel>("pdd.finance.balance.daily.bill.url.get", getFinanceBalanceDailyBillUrl);
            return result;
        }

    }
}
