namespace App.Models.PddApiResult
{
    
public class KeywordRelevanceList
{
    public int relevance { get; set; }
    public string word { get; set; }
}


public class AdKeywordRelevanceListResponse
{
    public List<KeywordRelevanceList> keyword_relevance_list { get; set; }
}


public class GetAdKeywordRelevanceApiResult
{
    public AdKeywordRelevanceListResponse ad_keyword_relevance_list_response { get; set; }
}

}
