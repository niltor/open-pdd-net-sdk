using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsOptList
{
    public int level { get; set; }
    public int opt_id { get; set; }
    public int parent_opt_id { get; set; }
    public string opt_name { get; set; }
}


public class GoodsOptGetResponse
{
    public List<GoodsOptList> goods_opt_list { get; set; }
}


public class GetGoodsOptApiResult
{
    public GoodsOptGetResponse goods_opt_get_response { get; set; }
}

}
