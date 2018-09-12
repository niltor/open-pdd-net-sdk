using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class LogisticsAddressList
{
    public int id { get; set; }
    public int parent_id { get; set; }
    public string region_name { get; set; }
    public int region_type { get; set; }
    public string national_code { get; set; }
    public int is_enabled { get; set; }
}


public class LogisticsAddressGetResponse
{
    public List<LogisticsAddressList> logistics_address_list { get; set; }
}


public class GetLogisticsAddressApiResult
{
    public LogisticsAddressGetResponse logistics_address_get_response { get; set; }
}

}
