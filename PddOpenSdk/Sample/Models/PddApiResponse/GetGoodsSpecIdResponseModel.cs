using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsSpecIdResponseModel : PddResponseModel
    {
        /// <summary>
/// 生成规格响应对象
/// </summary>
[JsonProperty("生成规格响应对象")]
public List<GoodsSpecIdGetResponse> GoodsSpecIdGetResponse {get;set;}
/// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("自定义规格所属的规格ID")]
public int ParentSpecId {get;set;}
/// <summary>
/// 生成的自定义规格名称
/// </summary>
[JsonProperty("生成的自定义规格名称")]
public string SpecName {get;set;}
/// <summary>
/// 生成的自定义规格ID
/// </summary>
[JsonProperty("生成的自定义规格ID")]
public int SpecId {get;set;}
}
}

    public partial class GoodsSpecIdGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("自定义规格所属的规格ID")]
public int ParentSpecId {get;set;}
/// <summary>
/// 生成的自定义规格名称
/// </summary>
[JsonProperty("生成的自定义规格名称")]
public string SpecName {get;set;}
/// <summary>
/// 生成的自定义规格ID
/// </summary>
[JsonProperty("生成的自定义规格ID")]
public int SpecId {get;set;}
}


