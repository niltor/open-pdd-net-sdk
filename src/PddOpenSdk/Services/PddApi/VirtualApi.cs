
using PddOpenSdk.Models.Request.Virtual;
using PddOpenSdk.Models.Response.Virtual;

namespace PddOpenSdk.Services.PddApi;
public class VirtualApi : PddCommonApi
{
    public VirtualApi() { }
    public VirtualApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 虚拟游戏类区服列表接口
    /// </summary>
    public async Task<QueryVirtualGameServerResponse> QueryVirtualGameServerAsync(QueryVirtualGameServer queryVirtualGameServer)
    {
        var result = await PostAsync<QueryVirtualGameServer, QueryVirtualGameServerResponse>("pdd.virtual.game.server.query", queryVirtualGameServer);
        return result;
    }

    /// <summary>
    /// 虚拟类目发货通知接口
    /// </summary>
    public async Task<NotifyVirtualMobileChargeResponse> NotifyVirtualMobileChargeAsync(NotifyVirtualMobileCharge notifyVirtualMobileCharge)
    {
        var result = await PostAsync<NotifyVirtualMobileCharge, NotifyVirtualMobileChargeResponse>("pdd.virtual.mobile.charge.notify", notifyVirtualMobileCharge);
        return result;
    }

}
