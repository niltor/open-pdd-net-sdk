using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class CreateGoodsMaterialResponseModel : PddResponseModel
{
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("error_code")]
public int? ErrorCode {get;set;}
/// <summary>
/// 错误文案
/// </summary>
[JsonProperty("error_msg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 返回素材id
/// </summary>
[JsonProperty("result")]
public long? Result {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}
