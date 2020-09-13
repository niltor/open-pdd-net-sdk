using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class InfoAdApiAdvertiserQueryAccountResponseModel : PddResponseModel
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
/// 
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 是否已开户
/// </summary>
[JsonProperty("hasOpenAccount")]
public bool? HasOpenAccount {get;set;}
/// <summary>
/// 是否已缴纳保证金
/// </summary>
[JsonProperty("hasPaidDeposit")]
public bool? HasPaidDeposit {get;set;}
/// <summary>
/// 是否已签署广告协议
/// </summary>
[JsonProperty("hasSignProtocol")]
public bool? HasSignProtocol {get;set;}
/// <summary>
/// 广告主ID
/// </summary>
[JsonProperty("mallId")]
public long? MallId {get;set;}

}

}

}

}
