namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsAdvicePriceResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_advice_price_get_response")]
    public GoodsAdvicePriceGetResponseResponse GoodsAdvicePriceGetResponse { get; set; }
    public partial class GoodsAdvicePriceGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 商品建议价列表
        /// </summary>
        [JsonPropertyName("advice_price_list")]
        public List<AdvicePriceListResponse> AdvicePriceList { get; set; }

        /// <summary>
        /// 商品建议价数据总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class AdvicePriceListResponse : PddResponseModel
        {

            /// <summary>
            /// sku建议价，单位为分
            /// </summary>
            [JsonPropertyName("advice_price")]
            public long? AdvicePrice { get; set; }

            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// sku拼单价，单位为分
            /// </summary>
            [JsonPropertyName("group_price")]
            public long? GroupPrice { get; set; }

            /// <summary>
            /// skuID
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long? SkuId { get; set; }

            /// <summary>
            /// sku名
            /// </summary>
            [JsonPropertyName("sku_name")]
            public string SkuName { get; set; }

        }

    }

}

