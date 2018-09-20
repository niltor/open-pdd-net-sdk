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
public GoodsBasicDetailResponseResponseModel GoodsBasicDetailResponse {get;set;}

    public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 列表
/// </summary>
[JsonProperty("list")]
public ListResponseModel List {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        
}

}

}
}
