using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsCrowdsResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_crows_query_response")]
public object SmsCrowsQueryResponse {get;set;}

    public partial class SmsCrowsQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
