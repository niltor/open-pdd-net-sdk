using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsSpecIdResponseModel : PddResponseModel
    {
        /// <summary>
/// 生成规格响应对象
/// </summary>
[JsonProperty("goods_spec_id_get_response")]
public List<GoodsSpecIdGetResponseResponseModel> GoodsSpecIdGetResponse {get;set;}
/// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("parent_spec_id")]
public int ParentSpecId {get;set;}
/// <summary>
/// 生成的自定义规格名称
/// </summary>
[JsonProperty("spec_name")]
public string SpecName {get;set;}
/// <summary>
/// 生成的自定义规格ID
/// </summary>
[JsonProperty("spec_id")]
public int SpecId {get;set;}

    public partial class GoodsSpecIdGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("parent_spec_id")]
public int ParentSpecId {get;set;}
/// <summary>
/// 生成的自定义规格名称
/// </summary>
[JsonProperty("spec_name")]
public string SpecName {get;set;}
/// <summary>
/// 生成的自定义规格ID
/// </summary>
[JsonProperty("spec_id")]
public int SpecId {get;set;}

}

}
}
