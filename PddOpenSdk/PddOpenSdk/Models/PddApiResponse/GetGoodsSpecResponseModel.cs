using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsSpecResponseModel : PddResponseModel
    {
        /// <summary>
/// 规格列表对象
/// </summary>
[JsonProperty("goods_spec_list")]
public object GoodsSpecList {get;set;}

    public partial class GoodsSpecListResponseModel : PddResponseModel
    {
        
}

}
}
