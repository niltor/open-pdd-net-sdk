namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsCatsList
{
    public int level { get; set; }
    public int cat_id { get; set; }
    public int parent_cat_id { get; set; }
    public string cat_name { get; set; }
}


public class GoodsCatsGetResponse
{
    public List<GoodsCatsList> goods_cats_list { get; set; }
}


public class GetGoodsCatsApiResult
{
    public GoodsCatsGetResponse goods_cats_get_response { get; set; }
}

}
