using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class UpdateStockWareSkuResponseModel : PddResponseModel
    {
        /// <summary>
        /// 操作成功：true
        /// </summary>
        [JsonProperty("open_api_response")]
        public bool? OpenApiResponse { get; set; }

    }

}
