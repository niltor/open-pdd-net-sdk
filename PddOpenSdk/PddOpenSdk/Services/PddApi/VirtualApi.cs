using PddOpenSdk.Models.Request.Virtual;
using PddOpenSdk.Models.Response.Virtual;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class VirtualApi : PddCommonApi
    {
        /// <summary>
        /// 虚拟游戏类区服列表接口
        /// </summary>
        public async Task<QueryVirtualGameServerResponseModel> QueryVirtualGameServerAsync(QueryVirtualGameServerRequestModel queryVirtualGameServer)
        {
            var result = await PostAsync<QueryVirtualGameServerRequestModel, QueryVirtualGameServerResponseModel>("pdd.virtual.game.server.query", queryVirtualGameServer);
            return result;
        }
        /// <summary>
        /// 虚拟类目发货通知接口
        /// </summary>
        public async Task<NotifyVirtualMobileChargeResponseModel> NotifyVirtualMobileChargeAsync(NotifyVirtualMobileChargeRequestModel notifyVirtualMobileCharge)
        {
            var result = await PostAsync<NotifyVirtualMobileChargeRequestModel, NotifyVirtualMobileChargeResponseModel>("pdd.virtual.mobile.charge.notify", notifyVirtualMobileCharge);
            return result;
        }

    }
}
