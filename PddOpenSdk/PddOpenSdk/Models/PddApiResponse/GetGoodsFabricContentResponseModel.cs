using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsFabricContentResponseModel : PddResponseModel
    {
        /// <summary>
/// 服饰成分含量对象列表
/// </summary>
[JsonProperty("goods_fabric_content_list")]
public object GoodsFabricContentList {get;set;}

    public partial class GoodsFabricContentListResponseModel : PddResponseModel
    {
        
}

}
}
