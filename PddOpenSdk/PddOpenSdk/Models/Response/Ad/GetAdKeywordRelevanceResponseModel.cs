using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class KeywordRelevanceList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("relevance")]
        public int Relevance { get; set; }

        /// <summary>
        /// Examples: "test"
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }
    }

    public class AdKeywordRelevanceListResponse
    {

        /// <summary>
        /// Examples: [{"relevance":1,"word":"test"}]
        /// </summary>
        [JsonProperty("keyword_relevance_list")]
        public IList<KeywordRelevanceList> KeywordRelevanceList { get; set; }
    }

    public class GetAdKeywordRelevanceResponseModel
    {

        /// <summary>
        /// Examples: {"keyword_relevance_list":[{"relevance":1,"word":"test"}]}
        /// </summary>
        [JsonProperty("ad_keyword_relevance_list_response")]
        public AdKeywordRelevanceListResponse AdKeywordRelevanceListResponse { get; set; }
    }


}
