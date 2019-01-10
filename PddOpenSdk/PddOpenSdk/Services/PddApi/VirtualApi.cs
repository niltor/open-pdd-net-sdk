using PddOpenSdk.Models.Request;
using PddOpenSdk.Models.Response;
using PddOpenSdk.Models.Request.Virtual;
using PddOpenSdk.Models.Response.Virtual;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{
    public class VirtualApi : PddCommonApi
    {
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
