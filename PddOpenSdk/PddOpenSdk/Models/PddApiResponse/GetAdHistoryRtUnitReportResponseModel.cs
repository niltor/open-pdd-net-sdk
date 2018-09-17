using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtUnitReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_real_time_report_response")]
        public object AdUnitRealTimeReportResponse { get; set; }

        public partial class AdUnitRealTimeReportResponseResponseModel : PddResponseModel
        {

        }

    }
}
