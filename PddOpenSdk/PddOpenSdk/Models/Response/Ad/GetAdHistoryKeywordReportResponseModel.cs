using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdKeywordHistoryReportGetResponse
    {

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("result")]
        public IList<object> Result { get; set; }
    }

    public class GetAdHistoryKeywordReportResponseModel
    {

        /// <summary>
        /// Examples: {"total":0,"result":[]}
        /// </summary>
        [JsonProperty("ad_keyword_history_report_get_response")]
        public AdKeywordHistoryReportGetResponse AdKeywordHistoryReportGetResponse { get; set; }
    }


}
