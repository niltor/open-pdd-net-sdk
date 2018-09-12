namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdPlanHistoryReportGetResponse
{
    public List<object> result { get; set; }
    public int total { get; set; }
}


public class GetAdHistoryPlanReportApiResult
{
    public AdPlanHistoryReportGetResponse ad_plan_history_report_get_response { get; set; }
}

}
