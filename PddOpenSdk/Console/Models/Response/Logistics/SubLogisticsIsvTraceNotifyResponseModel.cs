using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Logistics
{
public partial class SubLogisticsIsvTraceNotifyResponseModel : PddResponseModel
{
/// <summary>
/// 订阅响应对象
/// </summary>
[JsonProperty("logistics_isv_trace_notify_sub")]
public LogisticsIsvTraceNotifySubResponseModel LogisticsIsvTraceNotifySub {get;set;}
public partial class LogisticsIsvTraceNotifySubResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功，false-失败，true-成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
