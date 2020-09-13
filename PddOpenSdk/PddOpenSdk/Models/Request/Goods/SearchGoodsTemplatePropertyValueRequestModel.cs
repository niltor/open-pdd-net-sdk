using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class SearchGoodsTemplatePropertyValueRequestModel : PddRequestModel
{
/// <summary>
/// 类目id
/// </summary>
[JsonProperty("cat_id")]
public long CatId {get;set;}
/// <summary>
/// 页码 从1开始
/// </summary>
[JsonProperty("page_num")]
public int? PageNum {get;set;}
/// <summary>
/// 1页查询的最大数据 [1，500], 默认100
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 父属性值id
/// </summary>
[JsonProperty("parent_vid")]
public long? ParentVid {get;set;}
/// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("template_pid")]
public long TemplatePid {get;set;}
/// <summary>
/// 需要模糊搜索的属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 引用属性id
/// </summary>
[JsonProperty("ref_pid")]
public long? RefPid {get;set;}

}

}
