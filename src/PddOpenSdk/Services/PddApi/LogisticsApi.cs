
using PddOpenSdk.Models.Request.Logistics;
using PddOpenSdk.Models.Response.Logistics;
namespace PddOpenSdk.Services.PddApi;
public class LogisticsApi : PddCommonApi
{
    public LogisticsApi() { }
    public LogisticsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 获取拼多多标准地址库
    /// </summary>
    public async Task<GetLogisticsAddressResponse> GetLogisticsAddressAsync(GetLogisticsAddress getLogisticsAddress)
    {
        var result = await PostAsync<GetLogisticsAddress, GetLogisticsAddressResponse>("pdd.logistics.address.get", getLogisticsAddress);
        return result;
    }

    /// <summary>
    /// 获取可发货快递接口
    /// </summary>
    public async Task<RecommendLogisticsAvailableCompanyResponse> RecommendLogisticsAvailableCompanyAsync(RecommendLogisticsAvailableCompany recommendLogisticsAvailableCompany)
    {
        var result = await PostAsync<RecommendLogisticsAvailableCompany, RecommendLogisticsAvailableCompanyResponse>("pdd.logistics.available.company.recommend", recommendLogisticsAvailableCompany);
        return result;
    }

    /// <summary>
    /// 快递公司查看接口
    /// </summary>
    public async Task<GetLogisticsCompaniesResponse> GetLogisticsCompaniesAsync(GetLogisticsCompanies getLogisticsCompanies)
    {
        var result = await PostAsync<GetLogisticsCompanies, GetLogisticsCompaniesResponse>("pdd.logistics.companies.get", getLogisticsCompanies);
        return result;
    }

    /// <summary>
    /// 跨境全托管发货单发货
    /// </summary>
    public async Task<SendLogisticsFulfillmentResponse> SendLogisticsFulfillmentAsync(SendLogisticsFulfillment sendLogisticsFulfillment)
    {
        var result = await PostAsync<SendLogisticsFulfillment, SendLogisticsFulfillmentResponse>("pdd.logistics.fulfillment.send", sendLogisticsFulfillment);
        return result;
    }

    /// <summary>
    /// ISV物流轨迹推送消息订阅接口
    /// </summary>
    public async Task<SubLogisticsIsvTraceNotifyResponse> SubLogisticsIsvTraceNotifyAsync(SubLogisticsIsvTraceNotify subLogisticsIsvTraceNotify)
    {
        var result = await PostAsync<SubLogisticsIsvTraceNotify, SubLogisticsIsvTraceNotifyResponse>("pdd.logistics.isv.trace.notify.sub", subLogisticsIsvTraceNotify);
        return result;
    }

    /// <summary>
    /// 订单发货通知接口
    /// </summary>
    public async Task<SendLogisticsOnlineResponse> SendLogisticsOnlineAsync(SendLogisticsOnline sendLogisticsOnline)
    {
        var result = await PostAsync<SendLogisticsOnline, SendLogisticsOnlineResponse>("pdd.logistics.online.send", sendLogisticsOnline);
        return result;
    }

    /// <summary>
    /// 轨迹查询接口
    /// </summary>
    public async Task<GetLogisticsOrdertraceResponse> GetLogisticsOrdertraceAsync(GetLogisticsOrdertrace getLogisticsOrdertrace)
    {
        var result = await PostAsync<GetLogisticsOrdertrace, GetLogisticsOrdertraceResponse>("pdd.logistics.ordertrace.get", getLogisticsOrdertrace);
        return result;
    }

}
