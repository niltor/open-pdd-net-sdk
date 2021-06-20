using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
public partial class SubLogisticsCoTrackResponseModel : PddResponseModel
{
/// <summary>
/// 快递公司伙伴ID
/// </summary>
[JsonProperty("ship_id")]
public string ShipId {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
/// <summary>
/// 返回码
/// </summary>
[JsonProperty("reason_code")]
public string ReasonCode {get;set;}

}

}
