namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdUnitHistoryReportGetResponse
{
    public int total { get; set; }
    public List<object> result { get; set; }
}


public class GetAdHistoryUnitReportApiResult
{
    public AdUnitHistoryReportGetResponse ad_unit_history_report_get_response { get; set; }
}

}
