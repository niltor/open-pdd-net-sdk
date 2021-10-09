namespace PddOpenSdk.Models.Request.Goods;
public partial class UpdateGoodsSkuPrice
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 参考价 （单位分）
    /// </summary>
    [JsonPropertyName("market_price")]
    public long? MarketPrice { get; set; }

    /// <summary>
    /// 参考价 （单位元）
    /// </summary>
    [JsonPropertyName("market_price_in_yuan")]
    public string MarketPriceInYuan { get; set; }

    /// <summary>
    /// 待修改的sku价格
    /// </summary>
    [JsonPropertyName("sku_price_list")]
    public List<SkuPriceListModel> SkuPriceList { get; set; }

    /// <summary>
    /// 提交后上架状态，0:上架,1:保持原样
    /// </summary>
    [JsonPropertyName("sync_goods_operate")]
    public int? SyncGoodsOperate { get; set; }

    /// <summary>
    /// 是否获取商品发布警告信息，默认为忽略
    /// </summary>
    [JsonPropertyName("ignore_edit_warn")]
    public bool? IgnoreEditWarn { get; set; }
    public partial class SkuPriceListModel
    {

        /// <summary>
        /// 拼团购买价格（单位分）
        /// </summary>
        [JsonPropertyName("group_price")]
        public long GroupPrice { get; set; }

        /// <summary>
        /// sku上架状态，0-已下架，1-上架中
        /// </summary>
        [JsonPropertyName("is_onsale")]
        public int? IsOnsale { get; set; }

        /// <summary>
        /// 单独购买价格（单位分）
        /// </summary>
        [JsonPropertyName("single_price")]
        public long SinglePrice { get; set; }

        /// <summary>
        /// sku标识
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long SkuId { get; set; }

    }

}

