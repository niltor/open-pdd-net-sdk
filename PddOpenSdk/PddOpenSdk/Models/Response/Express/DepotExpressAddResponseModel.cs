using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class DepotExpressAddResponseModel : PddResponseModel
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
