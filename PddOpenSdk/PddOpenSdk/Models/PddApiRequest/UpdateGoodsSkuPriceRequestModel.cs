using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UpdateGoodsSkuPriceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public object GoodsId { get; set; }
        /// <summary>
        /// 待修改的sku价格
        /// </summary>
        [JsonProperty("sku_price_list")]
        public SkuPriceListRequestModel SkuPriceList { get; set; }

        public partial class SkuPriceListRequestModel : PddRequestModel
        {

        }

    }
}
