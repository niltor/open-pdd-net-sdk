using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DeleteAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_keyword_delete_response")]
public object AdKeywordDeleteResponse {get;set;}

    public partial class AdKeywordDeleteResponseResponseModel : PddResponseModel
    {
        
}

}
}
