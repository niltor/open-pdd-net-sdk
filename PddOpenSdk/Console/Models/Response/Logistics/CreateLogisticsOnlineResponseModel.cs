using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Logistics
{
public partial class CreateLogisticsOnlineResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("logistics_online_create_response")]
public LogisticsOnlineCreateResponseResponseModel LogisticsOnlineCreateResponse {get;set;}
public partial class LogisticsOnlineCreateResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
