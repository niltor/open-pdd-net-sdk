using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsUpdateSkuPriceResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateGoodsSkuPriceResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("goods_update_sku_price_response")]
        public GoodsUpdateSkuPriceResponse GoodsUpdateSkuPriceResponse { get; set; }
    }


}
