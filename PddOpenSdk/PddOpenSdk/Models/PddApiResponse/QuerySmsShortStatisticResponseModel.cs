using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsShortStatisticResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_short_msg_statistic_query_response")]
public object SmsShortMsgStatisticQueryResponse {get;set;}

    public partial class SmsShortMsgStatisticQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
