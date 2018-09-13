using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsCatsResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目树对象
/// </summary>
[JsonProperty("类目树对象")]
public List<GoodsCatsList> GoodsCatsList {get;set;}
/// <summary>
/// 类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
/// </summary>
[JsonProperty("类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目")]
public int Level {get;set;}
/// <summary>
/// 商品类目名称
/// </summary>
[JsonProperty("商品类目名称")]
public string CatName {get;set;}
/// <summary>
/// id所属父类目ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("id所属父类目ID，其中，parent_id=0时为顶级节点")]
public int ParentCatId {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("商品类目ID")]
public int CatId {get;set;}
}
}

    public partial class GoodsCatsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
/// </summary>
[JsonProperty("类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目")]
public int Level {get;set;}
/// <summary>
/// 商品类目名称
/// </summary>
[JsonProperty("商品类目名称")]
public string CatName {get;set;}
/// <summary>
/// id所属父类目ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("id所属父类目ID，其中，parent_id=0时为顶级节点")]
public int ParentCatId {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("商品类目ID")]
public int CatId {get;set;}
}


