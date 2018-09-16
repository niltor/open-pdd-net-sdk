using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情response
/// </summary>
[JsonProperty("goods_detail_get_response")]
public object GoodsDetailGetResponse {get;set;}

    public partial class GoodsDetailGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
