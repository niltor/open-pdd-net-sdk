namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsInformationResponse : PddResponseModel
{

    /// <summary>
    /// 商品详情响应对象
    /// </summary>
    [JsonPropertyName("goods_info_get_response")]
    public GoodsInfoGetResponseResponse GoodsInfoGetResponse { get; set; }
    public partial class GoodsInfoGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 商品详情对象
        /// </summary>
        [JsonPropertyName("goods_info")]
        public GoodsInfoResponse GoodsInfo { get; set; }
        public partial class GoodsInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 商品编码
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品序列编码
            /// </summary>
            [JsonPropertyName("goods_sn")]
            public string GoodsSn { get; set; }

            /// <summary>
            /// 1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡,18-CC行邮
            /// </summary>
            [JsonPropertyName("goods_type")]
            public int? GoodsType { get; set; }

            /// <summary>
            /// 商品一级类目
            /// </summary>
            [JsonPropertyName("goods_category")]
            public string GoodsCategory { get; set; }

            /// <summary>
            /// 叶子类目
            /// </summary>
            [JsonPropertyName("last_category")]
            public string LastCategory { get; set; }

            /// <summary>
            /// 是否七天无理由售后，0-不支持，1-支持
            /// </summary>
            [JsonPropertyName("is_refundable")]
            public int? IsRefundable { get; set; }

            /// <summary>
            /// 承诺发货时间
            /// </summary>
            [JsonPropertyName("shipment_limit_second")]
            public long? ShipmentLimitSecond { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品图片 url
            /// </summary>
            [JsonPropertyName("image_url")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 商品库存
            /// </summary>
            [JsonPropertyName("goods_quantity")]
            public int? GoodsQuantity { get; set; }

            /// <summary>
            /// 商品是否上架，0-下架，1-上架；
            /// </summary>
            [JsonPropertyName("is_onsale")]
            public int? IsOnsale { get; set; }

            /// <summary>
            /// 商品是否全新，0-全新商品，1-二手商品
            /// </summary>
            [JsonPropertyName("second_hand")]
            public int? SecondHand { get; set; }

            /// <summary>
            /// 成团人数
            /// </summary>
            [JsonPropertyName("group_required_customer_num")]
            public long? GroupRequiredCustomerNum { get; set; }

            /// <summary>
            /// sku列表对象
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListResponse> SkuList { get; set; }
            public partial class SkuListResponse : PddResponseModel
            {

                /// <summary>
                /// 商品规格名称
                /// </summary>
                [JsonPropertyName("spec")]
                public string Spec { get; set; }

                /// <summary>
                /// 商品sku编码
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// 商品sku库存
                /// </summary>
                [JsonPropertyName("sku_quantity")]
                public long? SkuQuantity { get; set; }

                /// <summary>
                /// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; }

                /// <summary>
                /// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
                /// </summary>
                [JsonPropertyName("outer_goods_id")]
                public string OuterGoodsId { get; set; }

                /// <summary>
                /// sku预览图
                /// </summary>
                [JsonPropertyName("sku_img")]
                public string SkuImg { get; set; }

                /// <summary>
                /// 拼团价格（元）
                /// </summary>
                [JsonPropertyName("group_price")]
                public string GroupPrice { get; set; }

                /// <summary>
                /// 单买价格（元）
                /// </summary>
                [JsonPropertyName("single_price")]
                public string SinglePrice { get; set; }

                /// <summary>
                /// 商品sku是否上架，0-下架，1-上架
                /// </summary>
                [JsonPropertyName("is_sku_onsale")]
                public int? IsSkuOnsale { get; set; }

            }

        }

    }

}

