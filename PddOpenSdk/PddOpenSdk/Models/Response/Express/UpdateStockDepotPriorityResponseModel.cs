using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class UpdateStockDepotPriorityResponseModel : PddResponseModel
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
