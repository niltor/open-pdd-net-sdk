namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsCatsList
{
    public int cat_id { get; set; }
    public string cat_name { get; set; }
}


public class GoodsAuthCatsGetResponse
{
    public List<GoodsCatsList> goods_cats_list { get; set; }
}


public class CatsGoodsAuthorizationApiResult
{
    public GoodsAuthCatsGetResponse goods_auth_cats_get_response { get; set; }
}

}
