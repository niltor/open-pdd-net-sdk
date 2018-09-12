namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsList
{
    public int goods_id { get; set; }
    public int min_normal_price { get; set; }
    public int min_group_price { get; set; }
    public string goods_pic { get; set; }
    public string goods_name { get; set; }
    public int goods_type { get; set; }
}


public class GoodsBasicDetailResponse
{
    public List<GoodsList> goods_list { get; set; }
}


public class GetDdkGoodsBasicInfoApiResult
{
    public GoodsBasicDetailResponse goods_basic_detail_response { get; set; }
}

}
