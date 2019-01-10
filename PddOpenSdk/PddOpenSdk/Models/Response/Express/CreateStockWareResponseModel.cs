using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class CreateStockWareResponseModel : PddResponseModel
    {
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty("open_api_response")]
        public int? OpenApiResponse { get; set; }

    }

}
