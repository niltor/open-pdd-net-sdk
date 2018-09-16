using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情响应对象
/// </summary>
[JsonProperty("goods_info_get_response")]
public object GoodsInfoGetResponse {get;set;}

    public partial class GoodsInfoGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
