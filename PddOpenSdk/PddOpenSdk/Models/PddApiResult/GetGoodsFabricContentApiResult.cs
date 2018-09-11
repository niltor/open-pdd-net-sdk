namespace App.Models.PddApiResult
{
    
public class GoodsFabricContentList
{
    public int code { get; set; }
    public string desc { get; set; }
}


public class GoodsFabricContentGetResponse
{
    public List<GoodsFabricContentList> goods_fabric_content_list { get; set; }
}


public class GetGoodsFabricContentApiResult
{
    public GoodsFabricContentGetResponse goods_fabric_content_get_response { get; set; }
}

}
