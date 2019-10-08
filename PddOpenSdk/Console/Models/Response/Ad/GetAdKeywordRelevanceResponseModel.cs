using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
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
/// 关键词相关新列表
/// </summary>
[JsonProperty("keyword_relevance_list")]
public List<KeywordRelevanceListResponseModel> KeywordRelevanceList {get;set;}
public partial class KeywordRelevanceListResponseModel : PddResponseModel
{
/// <summary>
/// 相关性
/// </summary>
[JsonProperty("relevance")]
public string Relevance {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public string Word {get;set;}

}

}

}

}
