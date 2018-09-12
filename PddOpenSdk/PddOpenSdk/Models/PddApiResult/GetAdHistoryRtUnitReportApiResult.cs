namespace PddOpenSdk.Models.PddApiResult
{
    
public class UnitRealTimeReportList
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
    public int unit_id { get; set; }
    public int plan_id { get; set; }
    public int goods_id { get; set; }
    public int operate_status { get; set; }
    public string goods_name { get; set; }
    public string thumb_url { get; set; }
    public int min_group_price { get; set; }
    public int max_group_price { get; set; }
    public int status { get; set; }
}


public class AdUnitRealTimeReportResponse
{
    public List<UnitRealTimeReportList> unit_real_time_report_list { get; set; }
}


public class GetAdHistoryRtUnitReportApiResult
{
    public AdUnitRealTimeReportResponse ad_unit_real_time_report_response { get; set; }
}

}
