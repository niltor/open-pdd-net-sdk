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
public GoodsSpecListResponseModel GoodsSpecList {get;set;}

    public partial class GoodsSpecListResponseModel : PddResponseModel
    {
        /// <summary>
/// 规格所属的叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
/// <summary>
/// 商品规格对应的ID
/// </summary>
[JsonProperty("parent_spec_id")]
public int ParentSpecId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("parent_spec_name")]
public string ParentSpecName {get;set;}

}

}
}
