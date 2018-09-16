using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_template_query_response")]
public object SmsTemplateQueryResponse {get;set;}
/// <summary>
/// 列表
/// </summary>
[JsonProperty("list")]
public object List {get;set;}
/// <summary>
/// 编号
/// </summary>
[JsonProperty("code")]
public int Code {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public object Desc {get;set;}

    public partial class SmsTemplateQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 列表
/// </summary>
[JsonProperty("list")]
public object List {get;set;}

}

    public partial class ListResponseModel : PddResponseModel
    {
        /// <summary>
/// 编号
/// </summary>
[JsonProperty("code")]
public int Code {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public object Desc {get;set;}

}

}
}
