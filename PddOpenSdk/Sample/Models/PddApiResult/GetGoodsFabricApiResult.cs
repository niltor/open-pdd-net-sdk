using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsFabricList
{
    public int code { get; set; }
    public string desc { get; set; }
}


public class GoodsFabricGetResponse
{
    public List<GoodsFabricList> goods_fabric_list { get; set; }
}


public class GetGoodsFabricApiResult
{
    public GoodsFabricGetResponse goods_fabric_get_response { get; set; }
}

}
