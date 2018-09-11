namespace PddOpenSdk.Models.PddApiResult
{
    
public class KeywordRealTimeReportList
{
    public int impression { get; set; }
    public int click { get; set; }
    public int ctr { get; set; }
    public int spend { get; set; }
    public int cpc { get; set; }
    public int order_num { get; set; }
    public int gmv { get; set; }
    public int roi { get; set; }
    public object cpm { get; set; }
    public int keyword_id { get; set; }
    public string word { get; set; }
    public int bid { get; set; }
    public int impression_status { get; set; }
    public int status { get; set; }
    public object quality_score { get; set; }
}


public class AdKeywordRealTimeReportResponse
{
    public List<KeywordRealTimeReportList> keyword_real_time_report_list { get; set; }
}


public class GetAdHistoryRtKeywordReportApiResult
{
    public AdKeywordRealTimeReportResponse ad_keyword_real_time_report_response { get; set; }
}

}
