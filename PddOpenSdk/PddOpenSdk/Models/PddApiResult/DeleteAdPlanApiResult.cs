namespace App.Models.PddApiResult
{
    
public class AdPlanDeleteResponse
{
    public bool is_success { get; set; }
}


public class DeleteAdPlanApiResult
{
    public AdPlanDeleteResponse ad_plan_delete_response { get; set; }
}

}
