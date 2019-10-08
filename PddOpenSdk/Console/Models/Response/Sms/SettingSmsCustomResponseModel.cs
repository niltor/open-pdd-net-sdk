using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Sms
{
public partial class SettingSmsCustomResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("sms_custom_setting_response")]
public SmsCustomSettingResponseResponseModel SmsCustomSettingResponse {get;set;}
public partial class SmsCustomSettingResponseResponseModel : PddResponseModel
{
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public long? Result {get;set;}

}

}

}
