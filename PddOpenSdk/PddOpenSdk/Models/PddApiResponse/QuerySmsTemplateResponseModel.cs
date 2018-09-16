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

    public partial class SmsTemplateQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
