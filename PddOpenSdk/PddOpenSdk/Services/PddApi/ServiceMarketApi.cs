
using PddOpenSdk.Models.Request.ServiceMarket;
using PddOpenSdk.Models.Response.ServiceMarket;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class ServiceMarketApi : PddCommonApi
    {
        public ServiceMarketApi() { }
        public ServiceMarketApi(string accessToken) { AccessToken = accessToken; }
        /// <summary>
        /// 月结算账单导出
        /// </summary>
        public async Task<GetServicemarketSettlementbillResponseModel> GetServicemarketSettlementbillAsync(GetServicemarketSettlementbillRequestModel getServicemarketSettlementbill)
        {
            var result = await PostAsync<GetServicemarketSettlementbillRequestModel, GetServicemarketSettlementbillResponseModel>("pdd.servicemarket.settlementbill.get", getServicemarketSettlementbill);
            return result;
        }
        /// <summary>
        /// 交易明细单导出
        /// </summary>
        public async Task<GetServicemarketTradelistResponseModel> GetServicemarketTradelistAsync(GetServicemarketTradelistRequestModel getServicemarketTradelist)
        {
            var result = await PostAsync<GetServicemarketTradelistRequestModel, GetServicemarketTradelistResponseModel>("pdd.servicemarket.tradelist.get", getServicemarketTradelist);
            return result;
        }
        /// <summary>
        /// 线上服务市场订单查询接口
        /// </summary>
        public async Task<SearchVasOrderResponseModel> SearchVasOrderAsync(SearchVasOrderRequestModel searchVasOrder)
        {
            var result = await PostAsync<SearchVasOrderRequestModel, SearchVasOrderResponseModel>("pdd.vas.order.search", searchVasOrder);
            return result;
        }

    }
}
