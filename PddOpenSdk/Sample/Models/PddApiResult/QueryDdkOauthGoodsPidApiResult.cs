using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class PIdList
{
    public string p_id { get; set; }
    public int create_time { get; set; }
}


public class PIdQueryResponse
{
    public List<PIdList> p_id_list { get; set; }
    public int total_count { get; set; }
}


public class QueryDdkOauthGoodsPidApiResult
{
    public PIdQueryResponse p_id_query_response { get; set; }
}

}
