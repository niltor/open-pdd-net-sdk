using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsCrowdsPeopleNumberResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_crows_people_number_query_response")]
public object SmsCrowsPeopleNumberQueryResponse {get;set;}

    public partial class SmsCrowsPeopleNumberQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
