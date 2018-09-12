namespace PddOpenSdk.Models.PddApiResult
{
    
public class PlanRealTimeReportList
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
    public int plan_id { get; set; }
    public string plan_name { get; set; }
    public int max_cost { get; set; }
    public int operate_status { get; set; }
    public int account_status { get; set; }
    public int status { get; set; }
    public object is_deleted { get; set; }
    public object ad_unit_num { get; set; }
}


public class AdPlanRealTimeReportResponse
{
    public List<PlanRealTimeReportList> plan_real_time_report_list { get; set; }
}


public class GetAdHistoryRtPlanReportApiResult
{
    public AdPlanRealTimeReportResponse ad_plan_real_time_report_response { get; set; }
}

}
