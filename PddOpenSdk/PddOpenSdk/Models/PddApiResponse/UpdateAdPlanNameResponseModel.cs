using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdPlanNameResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_name_update_response")]
public object AdPlanNameUpdateResponse {get;set;}

    public partial class AdPlanNameUpdateResponseResponseModel : PddResponseModel
    {
        
}

}
}
