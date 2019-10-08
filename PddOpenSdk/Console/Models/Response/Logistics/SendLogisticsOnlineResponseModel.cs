using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Logistics
{
public partial class SendLogisticsOnlineResponseModel : PddResponseModel
{
/// <summary>
/// 发货通知响应对象
/// </summary>
[JsonProperty("logistics_online_send_response")]
public LogisticsOnlineSendResponseResponseModel LogisticsOnlineSendResponse {get;set;}
public partial class LogisticsOnlineSendResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功，false-失败，true-成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
