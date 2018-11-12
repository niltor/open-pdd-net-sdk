using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UpdateGoodsSkuPriceResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_update_sku_price_response")]
        public GoodsUpdateSkuPriceResponseResponseModel GoodsUpdateSkuPriceResponse { get; set; }
        public partial class GoodsUpdateSkuPriceResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
