using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CatsGoodsAuthorizationResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目对象列表
/// </summary>
[JsonProperty("goods_cats_list")]
public object GoodsCatsList {get;set;}
/// <summary>
/// 对应ID下的类目名称
/// </summary>
[JsonProperty("cat_name")]
public object CatName {get;set;}
/// <summary>
/// 类目ID，一级类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}

    public partial class GoodsCatsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 对应ID下的类目名称
/// </summary>
[JsonProperty("cat_name")]
public object CatName {get;set;}
/// <summary>
/// 类目ID，一级类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}

}

}
}
