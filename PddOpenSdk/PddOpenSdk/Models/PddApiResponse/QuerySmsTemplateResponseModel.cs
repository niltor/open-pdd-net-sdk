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
public SmsTemplateQueryResponseResponseModel SmsTemplateQueryResponse {get;set;}

    public partial class SmsTemplateQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 列表
/// </summary>
[JsonProperty("list")]
public ListResponseModel List {get;set;}

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
public long Desc {get;set;}

}

}

}
}
