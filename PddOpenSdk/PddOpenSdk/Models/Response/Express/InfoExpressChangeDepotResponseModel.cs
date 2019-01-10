using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
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
