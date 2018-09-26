using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdMallHistoryReportResponse
    {

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("mall_history_report_list")]
        public IList<object> MallHistoryReportList { get; set; }
    }

    public class GetAdHistoryReportResponseModel
    {

        /// <summary>
        /// Examples: {"mall_history_report_list":[]}
        /// </summary>
        [JsonProperty("ad_mall_history_report_response")]
        public AdMallHistoryReportResponse AdMallHistoryReportResponse { get; set; }
    }


}
