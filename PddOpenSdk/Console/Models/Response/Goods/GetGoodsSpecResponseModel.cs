using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsSpecResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_spec_get_response")]
public GoodsSpecGetResponseResponseModel GoodsSpecGetResponse {get;set;}
public partial class GoodsSpecGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 规格列表对象
/// </summary>
[JsonProperty("goods_spec_list")]
public List<GoodsSpecListResponseModel> GoodsSpecList {get;set;}
public partial class GoodsSpecListResponseModel : PddResponseModel
{
/// <summary>
/// 规格所属的叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public long? CatId {get;set;}
/// <summary>
/// 商品规格对应的ID
/// </summary>
[JsonProperty("parent_spec_id")]
public long? ParentSpecId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("parent_spec_name")]
public string ParentSpecName {get;set;}

}

}

}

}
