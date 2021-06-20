using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.SmsVendor
{
public partial class CreateSmsVendorComplaintResponseModel : PddResponseModel
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
[JsonProperty("error_code")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("error_msg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
