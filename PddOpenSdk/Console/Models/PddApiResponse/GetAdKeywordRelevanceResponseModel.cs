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
public AdKeywordRelevanceListResponseResponseModel AdKeywordRelevanceListResponse {get;set;}

    public partial class AdKeywordRelevanceListResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// keyword_relevance_list
/// </summary>
[JsonProperty("keyword_relevance_list")]
public KeywordRelevanceListResponseModel KeywordRelevanceList {get;set;}

    public partial class KeywordRelevanceListResponseModel : PddResponseModel
    {
        /// <summary>
/// 相关性
/// </summary>
[JsonProperty("relevance")]
public int Relevance {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public string Word {get;set;}

}

}

}
}
