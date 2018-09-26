using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class KeywordRealTimeReportList
    {

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("impression")]
        public int Impression { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("click")]
        public int Click { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("ctr")]
        public int Ctr { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("spend")]
        public int Spend { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("cpc")]
        public int Cpc { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("order_num")]
        public int OrderNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("gmv")]
        public int Gmv { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("roi")]
        public int Roi { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cpm")]
        public object Cpm { get; set; }

        /// <summary>
        /// Examples: 1110046
        /// </summary>
        [JsonProperty("keyword_id")]
        public int KeywordId { get; set; }

        /// <summary>
        /// Examples: "桃"
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("bid")]
        public int Bid { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("impression_status")]
        public int ImpressionStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("quality_score")]
        public object QualityScore { get; set; }
    }

    public class AdKeywordRealTimeReportResponse
    {

        /// <summary>
        /// Examples: [{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"keyword_id":1110046,"word":"桃","bid":1000,"impression_status":1,"status":1,"quality_score":null}]
        /// </summary>
        [JsonProperty("keyword_real_time_report_list")]
        public IList<KeywordRealTimeReportList> KeywordRealTimeReportList { get; set; }
    }

    public class GetAdHistoryRtKeywordReportResponseModel
    {

        /// <summary>
        /// Examples: {"keyword_real_time_report_list":[{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"keyword_id":1110046,"word":"桃","bid":1000,"impression_status":1,"status":1,"quality_score":null}]}
        /// </summary>
        [JsonProperty("ad_keyword_real_time_report_response")]
        public AdKeywordRealTimeReportResponse AdKeywordRealTimeReportResponse { get; set; }
    }


}
