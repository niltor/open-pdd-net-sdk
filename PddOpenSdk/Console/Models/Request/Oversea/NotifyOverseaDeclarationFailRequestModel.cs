using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Oversea
{
public partial class NotifyOverseaDeclarationFailRequestModel : PddRequestModel
{
/// <summary>
/// 1=超过购买额度
/// </summary>
[JsonProperty("fail_reason")]
public int FailReason {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}
