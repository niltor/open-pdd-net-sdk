using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class ReportAdKeywordDailyResponseModel : PddResponseModel
    {
        /// <summary>
        /// 结果excel表格链接
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
