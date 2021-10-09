namespace PddOpenSdk.Models.Request.Stock;
public partial class UpdateStockWareSku
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("ware_id")]
    public long WareId { get; set; }

    /// <summary>
    /// 组合货品中子货品的关联关系
    /// </summary>
    [JsonPropertyName("ware_skus")]
    public List<WareSkusModel> WareSkus { get; set; }
    public partial class WareSkusModel
    {

        /// <summary>
        /// sku id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long GoodsId { get; set; }

    }

}

