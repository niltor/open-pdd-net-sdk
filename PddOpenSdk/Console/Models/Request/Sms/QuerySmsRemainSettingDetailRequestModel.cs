using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Sms
{
public partial class QuerySmsRemainSettingDetailRequestModel : PddRequestModel
{
/// <summary>
/// //1：提醒付款 ；  3：召唤买家成团
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}

}

}
