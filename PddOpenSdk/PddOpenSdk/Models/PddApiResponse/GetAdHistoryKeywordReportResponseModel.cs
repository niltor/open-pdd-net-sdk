using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryKeywordReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_history_report_get_response")]
        public object AdKeywordHistoryReportGetResponse { get; set; }

        public partial class AdKeywordHistoryReportGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
