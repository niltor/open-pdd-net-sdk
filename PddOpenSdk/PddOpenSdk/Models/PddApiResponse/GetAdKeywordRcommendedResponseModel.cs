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
public AdRecommendedKeywordListResponseResponseModel AdRecommendedKeywordListResponse {get;set;}

    public partial class AdRecommendedKeywordListResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// recommended_keyword_list
/// </summary>
[JsonProperty("keyword_relevance_list")]
public KeywordRelevanceListResponseModel KeywordRelevanceList {get;set;}

    public partial class KeywordRelevanceListResponseModel : PddResponseModel
    {
        /// <summary>
/// 分数
/// </summary>
[JsonProperty("score")]
public int Score {get;set;}
/// <summary>
/// 热度
/// </summary>
[JsonProperty("heat")]
public double Heat {get;set;}
/// <summary>
/// 趋势
/// </summary>
[JsonProperty("trend")]
public double Trend {get;set;}
/// <summary>
/// 竞争力
/// </summary>
[JsonProperty("compete")]
public double Compete {get;set;}
/// <summary>
/// 平均出价
/// </summary>
[JsonProperty("avg_bid")]
public double AvgBid {get;set;}
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
