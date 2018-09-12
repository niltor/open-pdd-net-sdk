using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class MallInfoGetResponse
{
    public string logo { get; set; }
    public string mall_name { get; set; }
    public string mall_desc { get; set; }
}


public class GetMallInfoApiResult
{
    public MallInfoGetResponse mall_info_get_response { get; set; }
}

}
