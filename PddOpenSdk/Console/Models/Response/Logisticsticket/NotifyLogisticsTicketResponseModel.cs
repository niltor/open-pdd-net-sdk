using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Logisticsticket
{
public partial class NotifyLogisticsTicketResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ticket_notify_response")]
public LogisticsTicketNotifyResponseResponseModel LogisticsTicketNotifyResponse {get;set;}
public partial class LogisticsTicketNotifyResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
