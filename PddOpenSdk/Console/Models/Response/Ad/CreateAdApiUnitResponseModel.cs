using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class CreateAdApiUnitResponseModel : PddResponseModel
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
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 单元Id
/// </summary>
[JsonProperty("result")]
public long? Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
