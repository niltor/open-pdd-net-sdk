using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtKeywordReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_real_time_report_response")]
        public object AdKeywordRealTimeReportResponse { get; set; }

        public partial class AdKeywordRealTimeReportResponseResponseModel : PddResponseModel
        {

        }

    }
}
