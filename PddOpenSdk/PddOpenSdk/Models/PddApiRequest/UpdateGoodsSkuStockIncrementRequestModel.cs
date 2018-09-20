using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UpdateGoodsSkuStockIncrementRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.sku.stock.increment.update
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 商品sku编码
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
        /// <summary>
        /// 外部编码 outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
        /// </summary>
        [JsonProperty("outer _id")]
        public string OuterId { get; set; }
        /// <summary>
        /// 增量库存值，222
        /// </summary>
        [JsonProperty("increment_quantity")]
        public object IncrementQuantity { get; set; }

    }
}
