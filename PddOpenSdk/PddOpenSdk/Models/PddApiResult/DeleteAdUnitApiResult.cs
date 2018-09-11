namespace App.Models.PddApiResult
{
    
public class AdUnitDeleteResponse
{
    public bool is_success { get; set; }
}


public class DeleteAdUnitApiResult
{
    public AdUnitDeleteResponse ad_unit_delete_response { get; set; }
}

}
