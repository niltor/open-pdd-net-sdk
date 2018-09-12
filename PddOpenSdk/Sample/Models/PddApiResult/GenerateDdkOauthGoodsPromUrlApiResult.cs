using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsPromotionUrlList
{
    public string url { get; set; }
    public string short_url { get; set; }
}


public class GoodsPromotionUrlGenerateResponse
{
    public List<GoodsPromotionUrlList> goods_promotion_url_list { get; set; }
}


public class GenerateDdkOauthGoodsPromUrlApiResult
{
    public GoodsPromotionUrlGenerateResponse goods_promotion_url_generate_response { get; set; }
}

}
