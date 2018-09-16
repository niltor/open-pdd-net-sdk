using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtPlanReportResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_real_time_report_response")]
public object AdPlanRealTimeReportResponse {get;set;}

    public partial class AdPlanRealTimeReportResponseResponseModel : PddResponseModel
    {
        
}

}
}
