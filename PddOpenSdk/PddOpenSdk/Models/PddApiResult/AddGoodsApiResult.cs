namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsAddResponse
{
    public int goods_id { get; set; }
    public long goods_commit_id { get; set; }
}


public class AddGoodsApiResult
{
    public GoodsAddResponse goods_add_response { get; set; }
}

}
