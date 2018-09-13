using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QuerySmsCustomTemplateRequestModel : PddRequestModel
    {
        /// <summary>
/// //1-审核中  2-审核驳回  3-审核通过
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// true or false//审核通过的排前面，在模版选择的时候调用
/// </summary>
[JsonProperty("order_by_status")]
public Boolean OrderByStatus {get;set;}
/// <summary>
/// 页码
/// </summary>
[JsonProperty("page_number")]
public int? PageNumber {get;set;}
/// <summary>
/// 每页大小
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// /**;      * 自定义模板类型;      * 0,正常模板;      * 1,需要带优惠券类型的模板;      */
/// </summary>
[JsonProperty("template_type")]
public int? TemplateType {get;set;}
}
}

