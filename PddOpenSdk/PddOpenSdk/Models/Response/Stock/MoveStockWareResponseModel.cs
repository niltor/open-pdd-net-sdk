using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Stock
{
    public class MoveStockWareResponseModel
    {

        /// <summary>
        /// Examples: 6001
        /// </summary>
        [JsonProperty("open_api_response")]
        public int OpenApiResponse { get; set; }
    }


}
