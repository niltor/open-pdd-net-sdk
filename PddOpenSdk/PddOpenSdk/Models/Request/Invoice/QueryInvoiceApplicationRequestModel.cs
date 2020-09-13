using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Invoice
{
public partial class QueryInvoiceApplicationRequestModel : PddRequestModel
{
/// <summary>
/// 申请流水号
/// </summary>
[JsonProperty("application_id")]
public long? ApplicationId {get;set;}
/// <summary>
/// 订单号；订单号和申请时间必填其一
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 页码，默认1
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 每页返回数目，默认50
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 申请状态：0-已拒绝，1-申请中，2-已同意
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 申请结束时间, 时间戳（毫秒）
/// </summary>
[JsonProperty("update_end_time")]
public long? UpdateEndTime {get;set;}
/// <summary>
/// 申请开始时间, 时间戳（毫秒）
/// </summary>
[JsonProperty("update_start_time")]
public long? UpdateStartTime {get;set;}

}

}
