using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CatsGoodsAuthorizationResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目对象列表
/// </summary>
[JsonProperty("goods_cats_list")]
public object GoodsCatsList {get;set;}

    public partial class GoodsCatsListResponseModel : PddResponseModel
    {
        
}

}
}
