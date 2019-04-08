using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Finance;
using PddOpenSdk.Models.Response.Finance;
namespace PddOpenSdk.Services.PddApi
{
    public class FinanceApi : PddCommonApi {
        /// <summary>
        /// 商家货款日账单下载链接查询接口
        /// </summary>
        public async Task<GetFinanceBalanceDailyBillUrlResponseModel> GetFinanceBalanceDailyBillUrlAsync (GetFinanceBalanceDailyBillUrlRequestModel getFinanceBalanceDailyBillUrl) {
            var result = await PostAsync<GetFinanceBalanceDailyBillUrlRequestModel, GetFinanceBalanceDailyBillUrlResponseModel> ("pdd.finance.balance.daily.bill.url.get", getFinanceBalanceDailyBillUrl);
            return result;
        }

    }
}