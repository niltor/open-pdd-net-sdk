using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Refund
{
public partial class AgreeRefundRequestModel : PddRequestModel
{
/// <summary>
/// request
/// </summary>
[JsonProperty("request")]
public RequestRequestModel Request {get;set;}
public partial class RequestRequestModel : PddRequestModel
{
/// <summary>
/// 售后id
/// </summary>
[JsonProperty("after_sales_id")]
public long AfterSalesId {get;set;}
/// <summary>
/// 退款备注，商家留言
/// </summary>
[JsonProperty("operate_desc")]
public string OperateDesc {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}
