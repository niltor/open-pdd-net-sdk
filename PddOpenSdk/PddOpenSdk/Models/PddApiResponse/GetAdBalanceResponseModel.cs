using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdBalanceResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("ad_balance_get_response")]
public object AdBalanceGetResponse {get;set;}

    public partial class AdBalanceGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
