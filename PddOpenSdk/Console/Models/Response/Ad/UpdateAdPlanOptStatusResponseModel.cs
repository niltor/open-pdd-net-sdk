using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class UpdateAdPlanOptStatusResponseModel : PddResponseModel
{
/// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_opt_status_update_response")]
public AdPlanOptStatusUpdateResponseResponseModel AdPlanOptStatusUpdateResponse {get;set;}
public partial class AdPlanOptStatusUpdateResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
