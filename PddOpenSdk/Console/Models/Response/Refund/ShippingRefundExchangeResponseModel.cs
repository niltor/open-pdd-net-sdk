using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Refund
{
public partial class ShippingRefundExchangeResponseModel : PddResponseModel
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
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("after_sales_id")]
public long? AfterSalesId {get;set;}
/// <summary>
/// 操作结果信息。如果失败，会返回失败原因
/// </summary>
[JsonProperty("message")]
public string Message {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 是否操作成功
/// </summary>
[JsonProperty("succ")]
public bool? Succ {get;set;}

}

}

}

}
