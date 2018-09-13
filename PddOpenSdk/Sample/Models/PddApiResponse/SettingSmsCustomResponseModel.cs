using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SettingSmsCustomResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_custom_setting_response")]
public object SmsCustomSettingResponse {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public int Result {get;set;}

    public partial class SmsCustomSettingResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public int Result {get;set;}

}

}
}
