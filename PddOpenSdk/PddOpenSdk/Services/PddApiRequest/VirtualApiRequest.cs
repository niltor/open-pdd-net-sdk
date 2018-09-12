using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class VirtualApiRequest : PddRequest {
        /// <summary>
/// 虚拟类目发货通知接口
/// </summary>
/// <param name="Type">该值为：pdd.virtual.mobile.charge.notify</param>
/// <param name="OrderSn">拼多多订单编码</param>
/// <param name="OuterOrderSn">11122dafa 外部系统订单编码</param>
/// <param name="Status">虚拟系统充值结果，SUCCESS-充值成功，FAIL-充值失败</param>
public async Task<NotifyVirtualMobileChargeApiResult> NotifyVirtualMobileChargeAsync(string Type,string OrderSn,string OuterOrderSn,string Status)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("order_sn",Order Sn);
dic.Add("outer_order_sn",Outer Order Sn);
dic.Add("status",Status);
    
    var result = Post<NotifyVirtualMobileChargeApiResult>(pdd.virtual.mobile.charge.notify,);
    return JsonConvert.DeserializeObject<NotifyVirtualMobileChargeApiResult>(result);
}
    }
}
