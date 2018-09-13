using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class QuerySmsCustomTemplateResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_custom_template_list_query_response")]
public object SmsCustomTemplateListQueryResponse {get;set;}
/// <summary>
/// 总数量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}
/// <summary>
/// 模板id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 模板名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_time")]
public object UpdatedTime {get;set;}
/// <summary>
/// 内容
/// </summary>
[JsonProperty("content")]
public object Content {get;set;}
/// <summary>
/// 状态
/// </summary>
[JsonProperty("status")]
public object Status {get;set;}
/// <summary>
/// 原因
/// </summary>
[JsonProperty("reason")]
public object Reason {get;set;}
/// <summary>
/// 类型
/// </summary>
[JsonProperty("type")]
public int Type {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}

    public partial class SmsCustomTemplateListQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 总数量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}

}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 模板id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 模板名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_time")]
public object UpdatedTime {get;set;}
/// <summary>
/// 内容
/// </summary>
[JsonProperty("content")]
public object Content {get;set;}
/// <summary>
/// 状态
/// </summary>
[JsonProperty("status")]
public object Status {get;set;}
/// <summary>
/// 原因
/// </summary>
[JsonProperty("reason")]
public object Reason {get;set;}

}

    public partial class ContentResponseModel : PddResponseModel
    {
        /// <summary>
/// 类型
/// </summary>
[JsonProperty("type")]
public int Type {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}

}

}
}
