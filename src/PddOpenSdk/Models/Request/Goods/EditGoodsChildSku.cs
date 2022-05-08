namespace PddOpenSdk.Models.Request.Goods;
public partial class EditGoodsChildSku
{

    /// <summary>
    /// 草稿id（未填写则新建一条商品草稿）
    /// </summary>
    [JsonPropertyName("goods_commit_id")]
    public long? GoodsCommitId { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 日历库存型商品sku信息列表
    /// </summary>
    [JsonPropertyName("skus")]
    public List<SkusModel> Skus { get; set; }

    /// <summary>
    /// 提交后上下架状态，0=上架；1=保持原样。表示编辑商品并提交后商品的上下架状态，不传时默认为0，上架。
    /// </summary>
    [JsonPropertyName("sync_goods_operate")]
    public int? SyncGoodsOperate { get; set; }
    public partial class SkusModel
    {

        /// <summary>
        /// 日历库存商品子sku信息列表
        /// </summary>
        [JsonPropertyName("child_skus")]
        public List<ChildSkusModel> ChildSkus { get; set; }

        /// <summary>
        /// 上架状态。0=已下架，1=已上架。不传表示不做修改
        /// </summary>
        [JsonPropertyName("is_onsale")]
        public int? IsOnsale { get; set; }

        /// <summary>
        /// 与sku_id必填其一，用于确定编辑的sku，当有多个sku的out_sku_sn一样时会编辑失败。
        /// </summary>
        [JsonPropertyName("out_sku_sn")]
        public string OutSkuSn { get; set; }

        /// <summary>
        /// 日历库存商品父skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long? SkuId { get; set; }
        public partial class ChildSkusModel
        {

            /// <summary>
            /// 售卖日期（“yyyy-MM-dd”）
            /// </summary>
            [JsonPropertyName("date")]
            public string Date { get; set; }

            /// <summary>
            /// 团购价
            /// </summary>
            [JsonPropertyName("group_price")]
            public long GroupPrice { get; set; }

            /// <summary>
            /// 库存增减
            /// </summary>
            [JsonPropertyName("quantity_delta")]
            public long QuantityDelta { get; set; }

            /// <summary>
            /// 单买价
            /// </summary>
            [JsonPropertyName("single_price")]
            public long SinglePrice { get; set; }

        }

    }

}

