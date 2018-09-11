namespace App.Models.PddApiResult
{
    
public class GoodsUpdateResponse
{
    public long goods_id { get; set; }
    public long goods_commit_id { get; set; }
}


public class CommitGoodsSubmitGoodsApiResult
{
    public GoodsUpdateResponse goods_update_response { get; set; }
}

}
