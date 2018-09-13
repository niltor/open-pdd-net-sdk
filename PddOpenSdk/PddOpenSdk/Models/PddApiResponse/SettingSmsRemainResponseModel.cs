using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SettingSmsRemainResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_remain_setting_response")]
public object SmsRemainSettingResponse {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public int Result {get;set;}

    public partial class SmsRemainSettingResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public int Result {get;set;}

}

}
}
