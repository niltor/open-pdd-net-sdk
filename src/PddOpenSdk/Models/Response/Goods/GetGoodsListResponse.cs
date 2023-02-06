namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsListResponse : PddResponseModel
{

    /// <summary>
    /// 商品列表响应对象
    /// </summary>
    [JsonPropertyName("goods_list_get_response")]
    public GoodsListGetResponseResponse GoodsListGetResponse { get; set; }
    public partial class GoodsListGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 商品列表对象
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<GoodsListResponse> GoodsList { get; set; }

        /// <summary>
        /// 返回商品总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class GoodsListResponse : PddResponseModel
        {

            /// <summary>
            /// 商品创建时间的时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至商品创建时间的总秒数
            /// </summary>
            [JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// 商品编码
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品总数量
            /// </summary>
            [JsonPropertyName("goods_quantity")]
            public long? GoodsQuantity { get; set; }

            /// <summary>
            /// 商品预扣库存
            /// </summary>
            [JsonPropertyName("goods_reserve_quantity")]
            public long? GoodsReserveQuantity { get; set; }

            /// <summary>
            /// 商品图片
            /// </summary>
            [JsonPropertyName("image_url")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 是否多sku，0-单sku，1-多sku
            /// </summary>
            [JsonPropertyName("is_more_sku")]
            public int? IsMoreSku { get; set; }

            /// <summary>
            /// 是否在架上，0-下架中，1-架上
            /// </summary>
            [JsonPropertyName("is_onsale")]
            public int? IsOnsale { get; set; }

            /// <summary>
            /// sku列表对象
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListResponse> SkuList { get; set; }

            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonPropertyName("thumb_url")]
            public string ThumbUrl { get; set; }
            public partial class SkuListResponse : PddResponseModel
            {

                /// <summary>
                /// sku是否在架上，0-下架中，1-架上
                /// </summary>
                [JsonPropertyName("is_sku_onsale")]
                public int? IsSkuOnsale { get; set; }

                /// <summary>
                /// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
                /// </summary>
                [JsonPropertyName("outer_goods_id")]
                public string OuterGoodsId { get; set; }

                /// <summary>
                /// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; }

                /// <summary>
                /// sku预扣库存
                /// </summary>
                [JsonPropertyName("reserve_quantity")]
                public long? ReserveQuantity { get; set; }

                /// <summary>
                /// sku编码
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// sku库存
                /// </summary>
                [JsonPropertyName("sku_quantity")]
                public long? SkuQuantity { get; set; }

                /// <summary>
                /// 规格名称
                /// </summary>
                [JsonPropertyName("spec")]
                public string Spec { get; set; }

                /// <summary>
                /// 规格信息
                /// </summary>
                [JsonPropertyName("spec_details")]
                public List<SpecDetailsResponse> SpecDetails { get; set; }
                public partial class SpecDetailsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 父规格id
                    /// </summary>
                    [JsonPropertyName("parent_id")]
                    public long? ParentId { get; set; }

                    /// <summary>
                    /// 父规格名
                    /// </summary>
                    [JsonPropertyName("parent_name")]
                    public string ParentName { get; set; }

                    /// <summary>
                    /// 子规格id
                    /// </summary>
                    [JsonPropertyName("spec_id")]
                    public long? SpecId { get; set; }

                    /// <summary>
                    /// 子规格名称
                    /// </summary>
                    [JsonPropertyName("spec_name")]
                    public string SpecName { get; set; }

                    /// <summary>
                    /// 规则备注
                    /// </summary>
                    [JsonPropertyName("spec_note")]
                    public string SpecNote { get; set; }

                }

            }

        }

    }

}

