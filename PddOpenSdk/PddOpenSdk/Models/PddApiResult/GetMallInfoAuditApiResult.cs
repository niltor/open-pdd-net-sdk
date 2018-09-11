namespace App.Models.PddApiResult
{
    
public class MallInfoAuditGetResponse
{
    public int audit_status { get; set; }
    public object validate_status { get; set; }
}


public class GetMallInfoAuditApiResult
{
    public MallInfoAuditGetResponse mall_info_audit_get_response { get; set; }
}

}
