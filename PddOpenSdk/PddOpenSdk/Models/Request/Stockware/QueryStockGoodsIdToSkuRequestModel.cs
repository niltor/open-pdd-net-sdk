using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stockware
{
    public partial class QueryStockGoodsIdToSkuRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty("ware_id")]
        public long WareId { get; set; }

    }

}
