using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Refund
{
public partial class AgreeRefundReturngoodsRequestModel : PddRequestModel
{
/// <summary>
/// 请求入参
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
/// 给用户留言
/// </summary>
[JsonProperty("operate_desc")]
public string OperateDesc {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 退货地址列表中已有的退货地址id
/// </summary>
[JsonProperty("return_address_id")]
public string ReturnAddressId {get;set;}

}

}

}
