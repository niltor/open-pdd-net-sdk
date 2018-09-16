using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_keyword_update_response")]
public object AdKeywordUpdateResponse {get;set;}

    public partial class AdKeywordUpdateResponseResponseModel : PddResponseModel
    {
        
}

}
}
