
using PddOpenSdk.Models.Request.Fds;
using PddOpenSdk.Models.Response.Fds;
namespace PddOpenSdk.Services.PddApi;
public class FdsApi : PddCommonApi
{
    public FdsApi() { }
    public FdsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 订单详情
    /// </summary>
    public async Task<GetFdsOrderResponse> GetFdsOrderAsync(GetFdsOrder getFdsOrder)
    {
        var result = await PostAsync<GetFdsOrder, GetFdsOrderResponse>("pdd.fds.order.get", getFdsOrder);
        return result;
    }

    /// <summary>
    /// 根据更新时间查询订单列表
    /// </summary>
    public async Task<GetFdsOrderListResponse> GetFdsOrderListAsync(GetFdsOrderList getFdsOrderList)
    {
        var result = await PostAsync<GetFdsOrderList, GetFdsOrderListResponse>("pdd.fds.order.list.get", getFdsOrderList);
        return result;
    }

    /// <summary>
    /// 查询店铺身份
    /// </summary>
    public async Task<GetFdsRoleResponse> GetFdsRoleAsync(GetFdsRole getFdsRole)
    {
        var result = await PostAsync<GetFdsRole, GetFdsRoleResponse>("pdd.fds.role.get", getFdsRole);
        return result;
    }

    /// <summary>
    /// 电子面单取消回传
    /// </summary>
    public async Task<CancelFdsWaybillResponse> CancelFdsWaybillAsync(CancelFdsWaybill cancelFdsWaybill)
    {
        var result = await PostAsync<CancelFdsWaybill, CancelFdsWaybillResponse>("pdd.fds.waybill.cancel", cancelFdsWaybill);
        return result;
    }

    /// <summary>
    /// 电子面单取号
    /// </summary>
    public async Task<GetFdsWaybillResponse> GetFdsWaybillAsync(GetFdsWaybill getFdsWaybill)
    {
        var result = await PostAsync<GetFdsWaybill, GetFdsWaybillResponse>("pdd.fds.waybill.get", getFdsWaybill);
        return result;
    }

    /// <summary>
    /// 电子面单回传
    /// </summary>
    public async Task<ReturnFdsWaybillResponse> ReturnFdsWaybillAsync(ReturnFdsWaybill returnFdsWaybill)
    {
        var result = await PostAsync<ReturnFdsWaybill, ReturnFdsWaybillResponse>("pdd.fds.waybill.return", returnFdsWaybill);
        return result;
    }

}
