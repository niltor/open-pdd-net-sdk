using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Open
{
public partial class MsgOpenMsgServiceSendBatchResponseModel : PddResponseModel
{
/// <summary>
/// 状态码
/// </summary>
[JsonProperty("code")]
public int? Code {get;set;}
/// <summary>
/// 状态原因
/// </summary>
[JsonProperty("message")]
public string Message {get;set;}
/// <summary>
/// 回执id
/// </summary>
[JsonProperty("biz_id")]
public string BizId {get;set;}

}

}
