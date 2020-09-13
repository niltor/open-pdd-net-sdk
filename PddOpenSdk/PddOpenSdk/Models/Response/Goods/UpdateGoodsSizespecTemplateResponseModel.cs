using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class UpdateGoodsSizespecTemplateResponseModel : PddResponseModel
{
/// <summary>
/// 响应
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("error_code")]
public int? ErrorCode {get;set;}
/// <summary>
/// 错误描述
/// </summary>
[JsonProperty("error_msg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 更新成功
/// </summary>
[JsonProperty("result")]
public bool? Result {get;set;}
/// <summary>
/// 请求成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
