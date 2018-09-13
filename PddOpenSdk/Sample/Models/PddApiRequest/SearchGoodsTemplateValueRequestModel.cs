using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SearchGoodsTemplateValueRequestModel : PddRequestModel
    {
        /// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("template_pid")]
public int TemplatePid {get;set;}
/// <summary>
/// 父属性值id
/// </summary>
[JsonProperty("parent_vid")]
public int ParentVid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
}
}

