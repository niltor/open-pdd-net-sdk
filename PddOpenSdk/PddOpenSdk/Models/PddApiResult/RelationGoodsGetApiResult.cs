namespace PddOpenSdk.Models.PddApiResult
{
    
public class QueryGoodsRelationResponse
{
    public object pdd_goods_id { get; set; }
    public int out_goods_platform { get; set; }
    public int out_goods_id { get; set; }
}


public class RelationGoodsGetApiResult
{
    public List<QueryGoodsRelationResponse> query_goods_relation_response { get; set; }
}

}
