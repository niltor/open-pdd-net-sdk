namespace App.Models.PddApiResult
{
    
public class GoodsSpecIdGetResponse
{
    public int parent_spec_id { get; set; }
    public string spec_name { get; set; }
    public int spec_id { get; set; }
}


public class GetGoodsSpecIdApiResult
{
    public GoodsSpecIdGetResponse goods_spec_id_get_response { get; set; }
}

}
