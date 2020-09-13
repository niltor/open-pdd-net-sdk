using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class RateAdApiUnitCreativeDistributeFlowRequestModel : PddRequestModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long AdId {get;set;}
/// <summary>
/// 流量分配比例。万分比
/// </summary>
[JsonProperty("creativeFlowRate")]
public int CreativeFlowRate {get;set;}

}

}
