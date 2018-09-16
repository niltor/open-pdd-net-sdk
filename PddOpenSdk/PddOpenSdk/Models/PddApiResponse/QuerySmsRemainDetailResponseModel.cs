using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsRemainDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_remain_detail_query_response")]
public object SmsRemainDetailQueryResponse {get;set;}

    public partial class SmsRemainDetailQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
