using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
public partial class SyncVoucherRealtimeVerifyResponseModel : PddResponseModel
{
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("code")]
public int? Code {get;set;}
/// <summary>
/// 错误描述
/// </summary>
[JsonProperty("message")]
public string Message {get;set;}

}

}
