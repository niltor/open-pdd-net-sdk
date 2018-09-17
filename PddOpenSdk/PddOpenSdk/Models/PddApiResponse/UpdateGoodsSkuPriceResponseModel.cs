using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuPriceResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_update_sku_price_response")]
        public object GoodsUpdateSkuPriceResponse { get; set; }

        public partial class GoodsUpdateSkuPriceResponseResponseModel : PddResponseModel
        {

        }

    }
}
