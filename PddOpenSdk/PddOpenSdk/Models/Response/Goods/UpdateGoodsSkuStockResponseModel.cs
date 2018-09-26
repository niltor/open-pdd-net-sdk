using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class SkuStockUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateGoodsSkuStockResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("sku_stock_update_response")]
        public SkuStockUpdateResponse SkuStockUpdateResponse { get; set; }
    }


}
