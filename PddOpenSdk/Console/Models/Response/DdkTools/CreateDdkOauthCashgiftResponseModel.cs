using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.DdkTools
{
public partial class CreateDdkOauthCashgiftResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("create_cashgift_response")]
public CreateCashgiftResponseResponseModel CreateCashgiftResponse {get;set;}
public partial class CreateCashgiftResponseResponseModel : PddResponseModel
{
/// <summary>
/// 礼金ID
/// </summary>
[JsonProperty("cash_gift_id")]
public long? CashGiftId {get;set;}
/// <summary>
/// 创建结果
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
