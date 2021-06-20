using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.SmsVendor
{
public partial class PushSmsDetailbillResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("sms_detailbill_push_resposne")]
public SmsDetailbillPushResposneResponseModel SmsDetailbillPushResposne {get;set;}
public partial class SmsDetailbillPushResposneResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
