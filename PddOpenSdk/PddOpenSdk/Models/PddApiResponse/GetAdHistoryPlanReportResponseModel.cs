using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryPlanReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_plan_history_report_get_response")]
        public object AdPlanHistoryReportGetResponse { get; set; }

        public partial class AdPlanHistoryReportGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
