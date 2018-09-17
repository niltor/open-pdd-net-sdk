using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryUnitReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_history_report_get_response")]
        public object AdUnitHistoryReportGetResponse { get; set; }

        public partial class AdUnitHistoryReportGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
