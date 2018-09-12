using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class Result
{
    public long date { get; set; }
    public int mall_id { get; set; }
    public int plan_id { get; set; }
    public object plan_name { get; set; }
    public int unit_id { get; set; }
    public string unit_name { get; set; }
    public int creative_id { get; set; }
    public string scene_info { get; set; }
    public int idx { get; set; }
    public object impr_num { get; set; }
    public object click_num { get; set; }
    public object spend { get; set; }
    public object pay_order_num { get; set; }
    public object pay_gmv { get; set; }
    public int plan_cpt_spend { get; set; }
    public string page_url { get; set; }
    public string image_url { get; set; }
}


public class AdCreativeReportGetResponse
{
    public int total { get; set; }
    public List<Result> result { get; set; }
}


public class GetAdCreativeReportApiResult
{
    public AdCreativeReportGetResponse ad_creative_report_get_response { get; set; }
}

}
