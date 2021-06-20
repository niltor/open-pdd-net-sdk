using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.DdkTools
{
public partial class UpdateDdkOauthCashgiftStatusResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("update_cashgift_response")]
public UpdateCashgiftResponseResponseModel UpdateCashgiftResponse {get;set;}
public partial class UpdateCashgiftResponseResponseModel : PddResponseModel
{
/// <summary>
/// 多多礼金ID
/// </summary>
[JsonProperty("cash_gift_id")]
public long? CashGiftId {get;set;}

}

}

}
