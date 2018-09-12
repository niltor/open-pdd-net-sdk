namespace PddOpenSdk.Models.PddApiResult
{
    
public class UnitBaseInfoList
{
    public int unit_id { get; set; }
    public int goods_id { get; set; }
    public int unit_status { get; set; }
    public int keyword_count { get; set; }
}


public class AdUnitBaseInfoListResponse
{
    public List<UnitBaseInfoList> unit_base_info_list { get; set; }
}


public class IdAdUnitGetByPlanApiResult
{
    public AdUnitBaseInfoListResponse ad_unit_base_info_List_response { get; set; }
}

}
