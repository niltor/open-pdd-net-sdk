using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
public partial class CloseLogisticsCsSessionResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("logistics_cs_session_close_response")]
public LogisticsCsSessionCloseResponseResponseModel LogisticsCsSessionCloseResponse {get;set;}
public partial class LogisticsCsSessionCloseResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
