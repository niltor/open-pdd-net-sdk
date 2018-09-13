using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SearchGoodsTemplateValueResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("response")]
public jsonstring TemplateValueSearchResponse {get;set;}
/// <summary>
/// 属性值列表
/// </summary>
[JsonProperty("属性值列表")]
public jsonstring TemplatePropertyValueList {get;set;}
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("属性值id")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Value {get;set;}
}
}

    public partial class TemplateValueSearchResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 属性值列表
/// </summary>
[JsonProperty("属性值列表")]
public jsonstring TemplatePropertyValueList {get;set;}
}


    public partial class TemplatePropertyValueListResponseModel : PddResponseModel
    {
        /// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("属性值id")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Value {get;set;}
}


