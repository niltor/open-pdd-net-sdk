using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkGoodsRecommendResponseModel : PddResponseModel
    {
        /// <summary>
/// goods_basic_detail_response
/// </summary>
[JsonProperty("goods_basic_detail_response")]
public object GoodsBasicDetailResponse {get;set;}

    public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel
    {
        
}

}
}
