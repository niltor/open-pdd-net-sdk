using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class ProfileAdApiUnitBidQueryInterestResponseModel : PddResponseModel
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
public List<ResultResponseModel> Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 兴趣点Id
/// </summary>
[JsonProperty("subLevelTargetId")]
public long? SubLevelTargetId {get;set;}
/// <summary>
/// 兴趣点名称
/// </summary>
[JsonProperty("subLevelTargetName")]
public string SubLevelTargetName {get;set;}
/// <summary>
/// 用户数量预估
/// </summary>
[JsonProperty("uvString")]
public string UvString {get;set;}

}

}

}

}
