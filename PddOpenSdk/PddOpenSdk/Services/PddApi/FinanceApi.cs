
using PddOpenSdk.Models.Request.Finance;
using PddOpenSdk.Models.Response.Finance;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{
    public class FinanceApi : PddCommonApi {
        public FinanceApi(){}
        public FinanceApi(string accessToken){AccessToken = accessToken;}
        /// <summary>
/// 商家货款日账单下载链接查询接口
/// </summary>
public async Task<GetFinanceBalanceDailyBillUrlResponseModel> GetFinanceBalanceDailyBillUrlAsync(GetFinanceBalanceDailyBillUrlRequestModel getFinanceBalanceDailyBillUrl)
{
    var result = await PostAsync<GetFinanceBalanceDailyBillUrlRequestModel,GetFinanceBalanceDailyBillUrlResponseModel>("pdd.finance.balance.daily.bill.url.get",getFinanceBalanceDailyBillUrl);
    return result;
}

    }
}
