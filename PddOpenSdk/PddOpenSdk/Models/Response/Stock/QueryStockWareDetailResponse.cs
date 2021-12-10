namespace PddOpenSdk.Models.Response.Stock;
public partial class QueryStockWareDetailResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public OpenApiResponseResponse OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 颜色
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// 创建时间（毫秒）
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 毛重：kg，精确到两位小数
        /// </summary>
        [JsonPropertyName("gross_weight")]
        public int? GrossWeight { get; set; }

        /// <summary>
        /// 高：厘米，精确到一位小数
        /// </summary>
        [JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 货品id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 长：厘米，精确到一位小数
        /// </summary>
        [JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// 净重：kg，精确到两位小数
        /// </summary>
        [JsonPropertyName("net_weight")]
        public int? NetWeight { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// 包材
        /// </summary>
        [JsonPropertyName("packing")]
        public string Packing { get; set; }

        /// <summary>
        /// 单价：元，精确到一位小数
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// 高低值服务，0低，1高
        /// </summary>
        [JsonPropertyName("service_quality")]
        public int? ServiceQuality { get; set; }

        /// <summary>
        /// 皮重：kg，精确到两位小数
        /// </summary>
        [JsonPropertyName("tare_weight")]
        public int? TareWeight { get; set; }

        /// <summary>
        /// 货品类型.0:单独货品  1:组合货品
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 更新时间毫秒）
        /// </summary>
        [JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// 体积：立方厘米，精确到一位小数
        /// </summary>
        [JsonPropertyName("volume")]
        public int? Volume { get; set; }

        /// <summary>
        /// 组合货品中子货品的关联关系
        /// </summary>
        [JsonPropertyName("ware_infos")]
        public List<WareInfosResponse> WareInfos { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [JsonPropertyName("ware_name")]
        public string WareName { get; set; }

        /// <summary>
        /// 货品sku信息
        /// </summary>
        [JsonPropertyName("ware_skus")]
        public List<WareSkusResponse> WareSkus { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonPropertyName("ware_sn")]
        public string WareSn { get; set; }

        /// <summary>
        /// 重量：kg，精确到两位小数
        /// </summary>
        [JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// 宽：厘米，精确到一位小数
        /// </summary>
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        public partial class WareInfosResponse : PddResponseModel
        {

            /// <summary>
            /// 子货品id
            /// </summary>
            [JsonPropertyName("ware_id")]
            public long? WareId { get; set; }

            /// <summary>
            /// 子货品名称
            /// </summary>
            [JsonPropertyName("ware_name")]
            public string WareName { get; set; }

            /// <summary>
            /// 子货品数量
            /// </summary>
            [JsonPropertyName("ware_quantity")]
            public long? WareQuantity { get; set; }

            /// <summary>
            /// 子货品编码
            /// </summary>
            [JsonPropertyName("ware_sn")]
            public string WareSn { get; set; }

        }
        public partial class WareSkusResponse : PddResponseModel
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
            /// 上下架状态，true表示上架
            /// </summary>
            [JsonPropertyName("is_onsale")]
            public bool? IsOnsale { get; set; }

            /// <summary>
            /// skuid
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

