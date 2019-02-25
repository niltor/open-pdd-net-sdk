using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class UpdateAdPlanMaxCostResponseModel : PddResponseModel
{
/// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_max_cost_update_response")]
public AdPlanMaxCostUpdateResponseResponseModel AdPlanMaxCostUpdateResponse {get;set;}
public partial class AdPlanMaxCostUpdateResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
