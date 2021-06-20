using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.ServiceMarket
{
public partial class GetServicemarketSettlementbillRequestModel : PddRequestModel
{
/// <summary>
/// 分页页码，最大不能超过1000
/// </summary>
[JsonProperty("page")]
public int Page {get;set;}
/// <summary>
/// 分页大小，最大不能超过100
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}
/// <summary>
/// 服务订单号
/// </summary>
[JsonProperty("service_order_sn")]
public string ServiceOrderSn {get;set;}
/// <summary>
/// 结算月份
/// </summary>
[JsonProperty("settle_month")]
public string SettleMonth {get;set;}

}

}
