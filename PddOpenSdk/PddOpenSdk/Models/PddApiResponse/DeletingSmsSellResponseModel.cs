using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DeletingSmsSellResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_deleting_response")]
public object SmsSellDeletingResponse {get;set;}

    public partial class SmsSellDeletingResponseResponseModel : PddResponseModel
    {
        
}

}
}
