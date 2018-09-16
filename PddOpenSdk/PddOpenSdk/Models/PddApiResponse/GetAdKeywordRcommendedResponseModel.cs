using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdKeywordRcommendedResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_recommended_keyword_list_response")]
public object AdRecommendedKeywordListResponse {get;set;}

    public partial class AdRecommendedKeywordListResponseResponseModel : PddResponseModel
    {
        
}

}
}
