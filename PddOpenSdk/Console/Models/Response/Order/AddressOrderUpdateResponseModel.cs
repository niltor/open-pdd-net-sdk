using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Order
{
public partial class AddressOrderUpdateResponseModel : PddResponseModel
{
/// <summary>
/// 请求响应
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 请求返回结果
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 是否请求成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 错误信息
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 提示文案
/// </summary>
[JsonProperty("msg")]
public string Msg {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}

}
