namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSkusResponse : PddResponseModel
{

    /// <summary>
    /// sku信息
    /// </summary>
    [JsonPropertyName("goods_sku_get_response")]
    public GoodsSkuGetResponseResponse GoodsSkuGetResponse { get; set; }
    public partial class GoodsSkuGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 该sku所在的商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 上下架状态，1=上架，0=下架
        /// </summary>
        [JsonPropertyName("is_onsale")]
        public int? IsOnsale { get; set; }

        /// <summary>
        /// 团购价，单位分
        /// </summary>
        [JsonPropertyName("multi_price")]
        public long? MultiPrice { get; set; }

        /// <summary>
        /// SKU维度商家外部编码
        /// </summary>
        [JsonPropertyName("out_sku_sn")]
        public string OutSkuSn { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// 预扣库存
        /// </summary>
        [JsonPropertyName("reserve_quantity")]
        public long? ReserveQuantity { get; set; }

        /// <summary>
        /// 单买价，单位分
        /// </summary>
        [JsonPropertyName("single_price")]
        public long? SinglePrice { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long? SkuId { get; set; }

        /// <summary>
        /// 规格列表
        /// </summary>
        [JsonPropertyName("spec")]
        public List<SpecResponse> Spec { get; set; }
        public partial class SpecResponse : PddResponseModel
        {

            /// <summary>
            /// 规格项ID
            /// </summary>
            [JsonPropertyName("parent_spec_id")]
            public long? ParentSpecId { get; set; }

            /// <summary>
            /// 规格项
            /// </summary>
            [JsonPropertyName("parent_spec_name")]
            public string ParentSpecName { get; set; }

            /// <summary>
            /// 规格ID
            /// </summary>
            [JsonPropertyName("spec_id")]
            public long? SpecId { get; set; }

            /// <summary>
            /// 规格值
            /// </summary>
            [JsonPropertyName("spec_name")]
            public string SpecName { get; set; }

            /// <summary>
            /// 规格备注
            /// </summary>
            [JsonPropertyName("spec_note")]
            public string SpecNote { get; set; }

        }

    }

}

