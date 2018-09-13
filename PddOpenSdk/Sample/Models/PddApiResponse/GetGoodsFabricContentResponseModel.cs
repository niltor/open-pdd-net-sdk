using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsFabricContentResponseModel : PddResponseModel
    {
        /// <summary>
/// 服饰成分含量对象列表
/// </summary>
[JsonProperty("goods_fabric_content_list")]
public List<GoodsFabricContentListResponseModel> GoodsFabricContentList {get;set;}
/// <summary>
/// 服饰成分含量 对应的ID，用于入参
/// </summary>
[JsonProperty("code")]
public int Code {get;set;}
/// <summary>
/// 对应ID下的服饰成分含量描述
/// </summary>
[JsonProperty("desc")]
public string Desc {get;set;}

    public partial class GoodsFabricContentListResponseModel : PddResponseModel
    {
        /// <summary>
/// 服饰成分含量 对应的ID，用于入参
/// </summary>
[JsonProperty("code")]
public int Code {get;set;}
/// <summary>
/// 对应ID下的服饰成分含量描述
/// </summary>
[JsonProperty("desc")]
public string Desc {get;set;}

}

}
}
