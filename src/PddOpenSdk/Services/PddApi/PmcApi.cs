
using PddOpenSdk.Models.Request.Pmc;
using PddOpenSdk.Models.Response.Pmc;
namespace PddOpenSdk.Services.PddApi;
public class PmcApi : PddCommonApi
{
    public PmcApi() { }
    public PmcApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 消息队列积压数量查询
    /// </summary>
    public async Task<QueryPmcAccrueResponse> QueryPmcAccrueAsync(QueryPmcAccrue queryPmcAccrue)
    {
        var result = await PostAsync<QueryPmcAccrue, QueryPmcAccrueResponse>("pdd.pmc.accrue.query", queryPmcAccrue);
        return result;
    }

    /// <summary>
    /// 取消用户的消息服务
    /// </summary>
    public async Task<CancelPmcUserResponse> CancelPmcUserAsync(CancelPmcUser cancelPmcUser)
    {
        var result = await PostAsync<CancelPmcUser, CancelPmcUserResponse>("pdd.pmc.user.cancel", cancelPmcUser);
        return result;
    }

    /// <summary>
    /// 获取用户已开通消息
    /// </summary>
    public async Task<GetPmcUserResponse> GetPmcUserAsync(GetPmcUser getPmcUser)
    {
        var result = await PostAsync<GetPmcUser, GetPmcUserResponse>("pdd.pmc.user.get", getPmcUser);
        return result;
    }

    /// <summary>
    /// 为已授权的用户开通消息服务
    /// </summary>
    public async Task<PermitPmcUserResponse> PermitPmcUserAsync(PermitPmcUser permitPmcUser)
    {
        var result = await PostAsync<PermitPmcUser, PermitPmcUserResponse>("pdd.pmc.user.permit", permitPmcUser);
        return result;
    }

}
