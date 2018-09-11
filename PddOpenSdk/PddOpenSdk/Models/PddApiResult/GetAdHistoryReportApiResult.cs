namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdMallHistoryReportResponse
{
    public List<object> mall_history_report_list { get; set; }
}


public class GetAdHistoryReportApiResult
{
    public AdMallHistoryReportResponse ad_mall_history_report_response { get; set; }
}

}
