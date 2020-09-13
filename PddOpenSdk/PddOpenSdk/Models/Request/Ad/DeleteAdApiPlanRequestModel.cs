using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class DeleteAdApiPlanRequestModel : PddRequestModel
{
/// <summary>
/// 广告计划Id
/// </summary>
[JsonProperty("planId")]
public long PlanId {get;set;}
/// <summary>
/// 场景类型，0-搜索，2-展示
/// </summary>
[JsonProperty("scenesType")]
public int ScenesType {get;set;}

}

}
