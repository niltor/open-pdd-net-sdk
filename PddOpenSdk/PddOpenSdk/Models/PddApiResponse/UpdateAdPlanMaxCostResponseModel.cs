using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdPlanMaxCostResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_max_cost_update_response")]
public object AdPlanMaxCostUpdateResponse {get;set;}

    public partial class AdPlanMaxCostUpdateResponseResponseModel : PddResponseModel
    {
        
}

}
}
