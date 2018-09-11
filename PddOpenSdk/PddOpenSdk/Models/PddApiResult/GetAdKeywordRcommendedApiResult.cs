namespace PddOpenSdk.Models.PddApiResult
{
    
public class RecommendedKeywordList
{
    public string word { get; set; }
    public int score { get; set; }
    public int relevance { get; set; }
    public double heat { get; set; }
    public double trend { get; set; }
    public double compete { get; set; }
    public double avg_bid { get; set; }
}


public class AdRecommendedKeywordListResponse
{
    public List<RecommendedKeywordList> recommended_keyword_list { get; set; }
}


public class GetAdKeywordRcommendedApiResult
{
    public AdRecommendedKeywordListResponse ad_recommended_keyword_list_response { get; set; }
}

}
