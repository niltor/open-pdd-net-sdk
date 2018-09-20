using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkGoodsBasicInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("goods_basic_detail_response")]
public GoodsBasicDetailResponseResponseModel GoodsBasicDetailResponse {get;set;}

    public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// list
/// </summary>
[JsonProperty("goods_list")]
public GoodsListResponseModel GoodsList {get;set;}

    public partial class GoodsListResponseModel : PddResponseModel
    {
        
}

}

}
}
