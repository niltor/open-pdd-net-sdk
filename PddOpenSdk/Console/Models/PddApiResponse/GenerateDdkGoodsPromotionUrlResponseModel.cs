using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkGoodsPromotionUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广链接对象列表
/// </summary>
[JsonProperty("goods_promotion_url_list")]
public List<GoodsPromotionUrlListResponseModel> GoodsPromotionUrlList {get;set;}

    public partial class GoodsPromotionUrlListResponseModel : PddResponseModel
    {
        
}

}
}
