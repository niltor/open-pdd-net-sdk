using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateAdPlanResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_create_response")]
public AdPlanCreateResponseResponseModel AdPlanCreateResponse {get;set;}

    public partial class AdPlanCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 广告计划id
/// </summary>
[JsonProperty("ad_plan_id")]
public int AdPlanId {get;set;}

}

}
}
