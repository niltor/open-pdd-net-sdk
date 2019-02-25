using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class UpdateAdPlanOptStatusRequestModel : PddRequestModel
{
/// <summary>
/// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}
/// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public long PlanId {get;set;}
/// <summary>
/// 1 已启用,2 已暂停
/// </summary>
[JsonProperty("opt_status")]
public int OptStatus {get;set;}

}

}
