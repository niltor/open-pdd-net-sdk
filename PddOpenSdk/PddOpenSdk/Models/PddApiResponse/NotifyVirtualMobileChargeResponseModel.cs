using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class NotifyVirtualMobileChargeResponseModel : PddResponseModel
    {
        /// <summary>
/// 虚拟充值回调通知响应对象
/// </summary>
[JsonProperty("mobile_charge_notify_response")]
public object MobileChargeNotifyResponse {get;set;}

    public partial class MobileChargeNotifyResponseResponseModel : PddResponseModel
    {
        
}

}
}
