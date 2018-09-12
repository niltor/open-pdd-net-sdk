namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsSpecList
{
    public int parent_spec_id { get; set; }
    public string parent_spec_name { get; set; }
    public int cat_id { get; set; }
}


public class GoodsSpecGetResponse
{
    public List<GoodsSpecList> goods_spec_list { get; set; }
}


public class GetGoodsSpecApiResult
{
    public GoodsSpecGetResponse goods_spec_get_response { get; set; }
}

}
