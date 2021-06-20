using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
public partial class QueryServiceMailServiceTimeResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("flag")]
public bool? Flag {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("serviceTimes")]
public List<ServiceTimesResponseModel> ServiceTimes {get;set;}
public partial class ServiceTimesResponseModel : PddResponseModel
{
/// <summary>
/// 开始服务时间
/// </summary>
[JsonProperty("startTime")]
public string StartTime {get;set;}
/// <summary>
/// 结束服务时间
/// </summary>
[JsonProperty("endTime")]
public string EndTime {get;set;}
/// <summary>
/// 服务日期
/// </summary>
[JsonProperty("serviceDate")]
public string ServiceDate {get;set;}

}

}

}

}
