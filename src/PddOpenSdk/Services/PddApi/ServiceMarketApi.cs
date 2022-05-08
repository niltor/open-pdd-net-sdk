
using PddOpenSdk.Models.Request.ServiceMarket;
using PddOpenSdk.Models.Response.ServiceMarket;
namespace PddOpenSdk.Services.PddApi;
public class ServiceMarketApi : PddCommonApi
{
    public ServiceMarketApi() { }
    public ServiceMarketApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 服务市场订单履约查询
    /// </summary>
    public async Task<SearchServicemarketContractResponse> SearchServicemarketContractAsync(SearchServicemarketContract searchServicemarketContract)
    {
        var result = await PostAsync<SearchServicemarketContract, SearchServicemarketContractResponse>("pdd.servicemarket.contract.search", searchServicemarketContract);
        return result;
    }

    /// <summary>
    /// 月结算账单导出
    /// </summary>
    public async Task<GetServicemarketSettlementbillResponse> GetServicemarketSettlementbillAsync(GetServicemarketSettlementbill getServicemarketSettlementbill)
    {
        var result = await PostAsync<GetServicemarketSettlementbill, GetServicemarketSettlementbillResponse>("pdd.servicemarket.settlementbill.get", getServicemarketSettlementbill);
        return result;
    }

    /// <summary>
    /// 交易明细单导出
    /// </summary>
    public async Task<GetServicemarketTradelistResponse> GetServicemarketTradelistAsync(GetServicemarketTradelist getServicemarketTradelist)
    {
        var result = await PostAsync<GetServicemarketTradelist, GetServicemarketTradelistResponse>("pdd.servicemarket.tradelist.get", getServicemarketTradelist);
        return result;
    }

    /// <summary>
    /// 线上服务市场订单查询接口
    /// </summary>
    public async Task<SearchVasOrderResponse> SearchVasOrderAsync(SearchVasOrder searchVasOrder)
    {
        var result = await PostAsync<SearchVasOrder, SearchVasOrderResponse>("pdd.vas.order.search", searchVasOrder);
        return result;
    }

}
