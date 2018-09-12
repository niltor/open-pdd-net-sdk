using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class PlanInfoList
{
    public object plan_id { get; set; }
    public string plan_name { get; set; }
    public int scene_type { get; set; }
    public int merchant_operate_status { get; set; }
    public int merchant_account_status { get; set; }
    public int max_cost { get; set; }
    public int? unit_num { get; set; }
}


public class AdPlanInfoListResponse
{
    public List<PlanInfoList> plan_info_list { get; set; }
}


public class GetAdPlanInfoListApiResult
{
    public AdPlanInfoListResponse ad_plan_info_list_response { get; set; }
}

}
