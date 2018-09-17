using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_mall_history_report_response")]
        public object AdMallHistoryReportResponse { get; set; }

        public partial class AdMallHistoryReportResponseResponseModel : PddResponseModel
        {

        }

    }
}
