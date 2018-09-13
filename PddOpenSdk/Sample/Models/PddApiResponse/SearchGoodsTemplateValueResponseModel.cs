using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SearchGoodsTemplateValueResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("template_value_search_response")]
public TemplateValueSearchResponseResponseModel TemplateValueSearchResponse {get;set;}
/// <summary>
/// 属性值列表
/// </summary>
[JsonProperty("template_property_value_list")]
public TemplatePropertyValueListResponseModel TemplatePropertyValueList {get;set;}
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("vid")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}

    public partial class TemplateValueSearchResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 属性值列表
/// </summary>
[JsonProperty("template_property_value_list")]
public TemplatePropertyValueListResponseModel TemplatePropertyValueList {get;set;}

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
[JsonProperty("vid")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}

}

}
}
