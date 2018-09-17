using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdCreativeReportResponseModel : PddResponseModel
    {
        /// <summary>
        /// ad_creative_report_get_response
        /// </summary>
        [JsonProperty("ad_creative_report_get_response")]
        public object AdCreativeReportGetResponse { get; set; }

        public partial class AdCreativeReportGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
