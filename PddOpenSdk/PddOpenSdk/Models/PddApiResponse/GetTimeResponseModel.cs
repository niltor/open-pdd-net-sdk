using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetTimeResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("time_get_response")]
public object TimeGetResponse {get;set;}

    public partial class TimeGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
