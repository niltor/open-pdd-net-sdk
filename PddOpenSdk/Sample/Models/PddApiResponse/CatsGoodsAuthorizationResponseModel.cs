using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CatsGoodsAuthorizationResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目对象列表
/// </summary>
[JsonProperty("类目对象列表")]
public List<GoodsCatsList> GoodsCatsList {get;set;}
/// <summary>
/// 对应ID下的类目名称
/// </summary>
[JsonProperty("对应ID下的类目名称")]
public string CatName {get;set;}
/// <summary>
/// 类目ID，一级类目ID
/// </summary>
[JsonProperty("类目ID，一级类目ID")]
public int CatId {get;set;}
}
}

    public partial class GoodsCatsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 对应ID下的类目名称
/// </summary>
[JsonProperty("对应ID下的类目名称")]
public string CatName {get;set;}
/// <summary>
/// 类目ID，一级类目ID
/// </summary>
[JsonProperty("类目ID，一级类目ID")]
public int CatId {get;set;}
}


