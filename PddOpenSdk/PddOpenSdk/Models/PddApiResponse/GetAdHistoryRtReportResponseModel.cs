using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtReportResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("ad_mall_real_time_report_response")]
public object AdMallRealTimeReportResponse {get;set;}

    public partial class AdMallRealTimeReportResponseResponseModel : PddResponseModel
    {
        
}

}
}
