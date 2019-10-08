using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsOuterCatMappingResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("outer_cat_mapping_get_response")]
public OuterCatMappingGetResponseResponseModel OuterCatMappingGetResponse {get;set;}
public partial class OuterCatMappingGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 一级类目
/// </summary>
[JsonProperty("cat_id1")]
public long? CatId1 {get;set;}
/// <summary>
/// 二级类目
/// </summary>
[JsonProperty("cat_id2")]
public long? CatId2 {get;set;}
/// <summary>
/// 三级类目
/// </summary>
[JsonProperty("cat_id3")]
public long? CatId3 {get;set;}
/// <summary>
/// 四级类目
/// </summary>
[JsonProperty("cat_id4")]
public long? CatId4 {get;set;}

}

}

}
