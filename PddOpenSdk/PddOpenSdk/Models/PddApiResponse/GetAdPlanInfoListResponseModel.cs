using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdPlanInfoListResponseModel : PddResponseModel
    {
        /// <summary>
/// 计划基础信息表
/// </summary>
[JsonProperty("ad_plan_info_list_response")]
public object AdPlanInfoListResponse {get;set;}

    public partial class AdPlanInfoListResponseResponseModel : PddResponseModel
    {
        
}

}
}
