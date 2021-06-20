using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.ServiceMarket
{
public partial class GetServicemarketTradelistRequestModel : PddRequestModel
{
/// <summary>
/// 查询起始时间，精确到秒，起止时间间隔最大31天
/// </summary>
[JsonProperty("begin_time")]
public int BeginTime {get;set;}
/// <summary>
/// 查询结束时间，精确到秒，起止时间间隔最大31天
/// </summary>
[JsonProperty("end_time")]
public int EndTime {get;set;}
/// <summary>
/// 收支类型，空-全部 1-收入 2-支出
/// </summary>
[JsonProperty("group_type")]
public int? GroupType {get;set;}
/// <summary>
/// 分页页码，最大1000
/// </summary>
[JsonProperty("page")]
public int Page {get;set;}
/// <summary>
/// 分页大小，最大1000
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}
/// <summary>
/// 服务订单号
/// </summary>
[JsonProperty("service_order_sn")]
public string ServiceOrderSn {get;set;}

}

}
