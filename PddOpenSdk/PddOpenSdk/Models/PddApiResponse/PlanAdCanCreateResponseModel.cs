using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class PlanAdCanCreateResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("ad_plan_create_response")]
public object AdPlanCreateResponse {get;set;}

    public partial class AdPlanCreateResponseResponseModel : PddResponseModel
    {
        
}

}
}
