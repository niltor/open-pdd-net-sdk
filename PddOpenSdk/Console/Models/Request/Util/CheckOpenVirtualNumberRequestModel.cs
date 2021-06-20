using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Util
{
public partial class CheckOpenVirtualNumberRequestModel : PddRequestModel
{
/// <summary>
/// 分机号，非必填，4位数字字符
/// </summary>
[JsonProperty("identify_number")]
public string IdentifyNumber {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 虚拟号，11位数字字符
/// </summary>
[JsonProperty("virtual_number")]
public string VirtualNumber {get;set;}

}

}
