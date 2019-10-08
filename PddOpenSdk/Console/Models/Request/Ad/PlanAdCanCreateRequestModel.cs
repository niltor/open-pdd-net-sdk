using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class PlanAdCanCreateRequestModel : PddRequestModel
{
/// <summary>
/// 计划名
/// </summary>
[JsonProperty("plan_name")]
public string PlanName {get;set;}
/// <summary>
/// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}

}

}
