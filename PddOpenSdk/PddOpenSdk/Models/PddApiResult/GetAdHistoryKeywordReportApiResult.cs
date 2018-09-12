namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdKeywordHistoryReportGetResponse
{
    public int total { get; set; }
    public List<object> result { get; set; }
}


public class GetAdHistoryKeywordReportApiResult
{
    public AdKeywordHistoryReportGetResponse ad_keyword_history_report_get_response { get; set; }
}

}
