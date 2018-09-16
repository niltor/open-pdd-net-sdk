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
/// <summary>
/// 是否可以创建
/// </summary>
[JsonProperty("creatable")]
public object Creatable {get;set;}

    public partial class AdPlanCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否可以创建
/// </summary>
[JsonProperty("creatable")]
public object Creatable {get;set;}

}

}
}
