using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class InfoExpressChangeDepotResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
