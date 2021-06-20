using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class ProfileAdApiUnitBidQueryBaseLocationResponseModel : PddResponseModel
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
/// 资源位描述
/// </summary>
[JsonProperty("locationName")]
public string LocationName {get;set;}
/// <summary>
/// 资源位类型
/// </summary>
[JsonProperty("locationType")]
public int? LocationType {get;set;}
/// <summary>
/// 资源位预估人群
/// </summary>
[JsonProperty("pvString")]
public string PvString {get;set;}

}

}

}

}
