using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsCatsResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目树对象
/// </summary>
[JsonProperty("goods_cats_list")]
public object GoodsCatsList {get;set;}
/// <summary>
/// 类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
/// </summary>
[JsonProperty("level")]
public int Level {get;set;}
/// <summary>
/// 商品类目名称
/// </summary>
[JsonProperty("cat_name")]
public object CatName {get;set;}
/// <summary>
/// id所属父类目ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("parent_cat_id")]
public int ParentCatId {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}

    public partial class GoodsCatsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
/// </summary>
[JsonProperty("level")]
public int Level {get;set;}
/// <summary>
/// 商品类目名称
/// </summary>
[JsonProperty("cat_name")]
public object CatName {get;set;}
/// <summary>
/// id所属父类目ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("parent_cat_id")]
public int ParentCatId {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}

}

}
}
