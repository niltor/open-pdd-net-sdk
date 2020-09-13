using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class NameAdApiUnitUpdateUnitRequestModel : PddRequestModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long AdId {get;set;}
/// <summary>
/// 单元名称
/// </summary>
[JsonProperty("adName")]
public string AdName {get;set;}

}

}
