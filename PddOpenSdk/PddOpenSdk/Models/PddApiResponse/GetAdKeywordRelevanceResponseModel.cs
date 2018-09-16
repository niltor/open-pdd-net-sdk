using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdKeywordRelevanceResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_keyword_relevance_list_response")]
public object AdKeywordRelevanceListResponse {get;set;}

    public partial class AdKeywordRelevanceListResponseResponseModel : PddResponseModel
    {
        
}

}
}
