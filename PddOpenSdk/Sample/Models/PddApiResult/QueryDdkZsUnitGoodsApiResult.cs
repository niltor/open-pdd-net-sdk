using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class ZsUnitGoodsQueryResponse
{
    public List<object> list { get; set; }
    public int total_count { get; set; }
}


public class QueryDdkZsUnitGoodsApiResult
{
    public ZsUnitGoodsQueryResponse zs_unit_goods_query_response { get; set; }
}

}
