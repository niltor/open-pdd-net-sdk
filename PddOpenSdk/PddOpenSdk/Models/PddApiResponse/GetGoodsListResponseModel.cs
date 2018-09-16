using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品列表响应对象
/// </summary>
[JsonProperty("goods_list_get_response")]
public object GoodsListGetResponse {get;set;}

    public partial class GoodsListGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
