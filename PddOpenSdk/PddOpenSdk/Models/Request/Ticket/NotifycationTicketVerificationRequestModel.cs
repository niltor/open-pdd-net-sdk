using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ticket
{
public partial class NotifycationTicketVerificationRequestModel : PddRequestModel
{
/// <summary>
/// 拼多多制票号
/// </summary>
[JsonProperty("order_no")]
public string OrderNo {get;set;}
/// <summary>
/// 核销时间（13位毫秒数）
/// </summary>
[JsonProperty("verify_time")]
public long VerifyTime {get;set;}

}

}
