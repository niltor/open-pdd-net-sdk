namespace PddOpenSdk.Models.Response.Stock;
public partial class QueryStockGoodsIdToSkuResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public OpenApiResponseResponse OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// sku信息
        /// </summary>
        [JsonPropertyName("skus")]
        public List<SkusResponse> Skus { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class SkusResponse : PddResponseModel
        {

            /// <summary>
            /// 是否已经绑定货品false/true
            /// </summary>
            [JsonPropertyName("exist_ware")]
            public bool? ExistWare { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 上下架状态，true表示上架，false表示下架
            /// </summary>
            [JsonPropertyName("is_onsale")]
            public bool? IsOnsale { get; set; }

            /// <summary>
            /// sku_id
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long? SkuId { get; set; }

            /// <summary>
            /// 规格信息
            /// </summary>
            [JsonPropertyName("specs")]
            public List<SpecsResponse> Specs { get; set; }

            /// <summary>
            /// 货品id
            /// </summary>
            [JsonPropertyName("ware_id")]
            public long? WareId { get; set; }
            public partial class SpecsResponse : PddResponseModel
            {

                /// <summary>
                /// 规格id
                /// </summary>
                [JsonPropertyName("spec_id")]
                public long? SpecId { get; set; }

                /// <summary>
                /// 规格名称
                /// </summary>
                [JsonPropertyName("spec_key")]
                public string SpecKey { get; set; }

                /// <summary>
                /// 规格值
                /// </summary>
                [JsonPropertyName("spec_value")]
                public string SpecValue { get; set; }

            }

        }

    }

}

