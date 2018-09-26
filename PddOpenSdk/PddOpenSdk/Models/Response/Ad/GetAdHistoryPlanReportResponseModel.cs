using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdPlanHistoryReportGetResponse
    {

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("result")]
        public IList<object> Result { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetAdHistoryPlanReportResponseModel
    {

        /// <summary>
        /// Examples: {"result":[],"total":0}
        /// </summary>
        [JsonProperty("ad_plan_history_report_get_response")]
        public AdPlanHistoryReportGetResponse AdPlanHistoryReportGetResponse { get; set; }
    }


}
