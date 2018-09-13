using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsSpecResponseModel : PddResponseModel
    {
        /// <summary>
/// 规格列表对象
/// </summary>
[JsonProperty("规格列表对象")]
public List<GoodsSpecList> GoodsSpecList {get;set;}
/// <summary>
/// 规格所属的叶子类目ID
/// </summary>
[JsonProperty("规格所属的叶子类目ID")]
public int CatId {get;set;}
/// <summary>
/// 商品规格对应的ID
/// </summary>
[JsonProperty("商品规格对应的ID")]
public int ParentSpecId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("商品规格ID对应的规格名称")]
public string ParentSpecName {get;set;}
}
}

    public partial class GoodsSpecListResponseModel : PddResponseModel
    {
        /// <summary>
/// 规格所属的叶子类目ID
/// </summary>
[JsonProperty("规格所属的叶子类目ID")]
public int CatId {get;set;}
/// <summary>
/// 商品规格对应的ID
/// </summary>
[JsonProperty("商品规格对应的ID")]
public int ParentSpecId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("商品规格ID对应的规格名称")]
public string ParentSpecName {get;set;}
}


