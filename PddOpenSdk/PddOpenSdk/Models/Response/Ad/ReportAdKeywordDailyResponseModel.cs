using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
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
