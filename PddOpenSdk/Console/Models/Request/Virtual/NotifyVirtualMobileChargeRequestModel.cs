using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Virtual
{
public partial class NotifyVirtualMobileChargeRequestModel : PddRequestModel
{
/// <summary>
/// 拼多多订单编码
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 11122dafa 外部系统订单编码
/// </summary>
[JsonProperty("outer_order_sn")]
public string OuterOrderSn {get;set;}
/// <summary>
/// 虚拟系统充值结果，SUCCESS-充值成功，FAIL-充值失败
/// </summary>
[JsonProperty("status")]
public string Status {get;set;}

}

}
