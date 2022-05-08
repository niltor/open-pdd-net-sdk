namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderBasicListResponse : PddResponseModel
{

    /// <summary>
    /// 请求response
    /// </summary>
    [JsonPropertyName("order_basic_list_get_response")]
    public OrderBasicListGetResponseResponse OrderBasicListGetResponse { get; set; }
    public partial class OrderBasicListGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [JsonPropertyName("has_next")]
        public bool? HasNext { get; set; }

        /// <summary>
        /// 订单信息列表
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<OrderListResponse> OrderList { get; set; }

        /// <summary>
        /// 订单总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class OrderListResponse : PddResponseModel
        {

            /// <summary>
            /// 商品一级分类
            /// </summary>
            [JsonPropertyName("cat_id_1")]
            public long? CatId1 { get; set; }

            /// <summary>
            /// 商品二级分类
            /// </summary>
            [JsonPropertyName("cat_id_2")]
            public long? CatId2 { get; set; }

            /// <summary>
            /// 商品三级分类
            /// </summary>
            [JsonPropertyName("cat_id_3")]
            public long? CatId3 { get; set; }

            /// <summary>
            /// 商品四级分类
            /// </summary>
            [JsonPropertyName("cat_id_4")]
            public long? CatId4 { get; set; }

            /// <summary>
            /// 成交时间
            /// </summary>
            [JsonPropertyName("confirm_time")]
            public string ConfirmTime { get; set; }

            /// <summary>
            /// 送货入户费用 单位：元
            /// </summary>
            [JsonPropertyName("delivery_home_value")]
            public double? DeliveryHomeValue { get; set; }

            /// <summary>
            /// 送货入户并安装费用 单位：元
            /// </summary>
            [JsonPropertyName("delivery_install_value")]
            public double? DeliveryInstallValue { get; set; }

            /// <summary>
            /// 折扣金额，单位：元，折扣金额=平台优惠+商家优惠+团长免单优惠金额
            /// </summary>
            [JsonPropertyName("discount_amount")]
            public double? DiscountAmount { get; set; }

            /// <summary>
            /// 商品金额，单位：元，商品金额=商品销售价格*商品数量-改价金额（接口暂无该字段）
            /// </summary>
            [JsonPropertyName("goods_amount")]
            public double? GoodsAmount { get; set; }

            /// <summary>
            /// 送货入户并安装服务 0-不支持送货，1-送货入户不安装，2-送货入户并安装
            /// </summary>
            [JsonPropertyName("home_delivery_type")]
            public int? HomeDeliveryType { get; set; }

            /// <summary>
            /// 上门安装费用 单位：元
            /// </summary>
            [JsonPropertyName("home_install_value")]
            public double? HomeInstallValue { get; set; }

            /// <summary>
            /// 是否是抽奖订单，1-非抽奖订单，2-抽奖订单
            /// </summary>
            [JsonPropertyName("is_lucky_flag")]
            public int? IsLuckyFlag { get; set; }

            /// <summary>
            /// 订单商品列表
            /// </summary>
            [JsonPropertyName("item_list")]
            public List<ItemListResponse> ItemList { get; set; }

            /// <summary>
            /// 订单编号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 订单状态
            /// </summary>
            [JsonPropertyName("order_status")]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// 支付金额，单位：元，支付金额=商品金额-折扣金额+邮费
            /// </summary>
            [JsonPropertyName("pay_amount")]
            public double? PayAmount { get; set; }

            /// <summary>
            /// 平台优惠金额，单位：元
            /// </summary>
            [JsonPropertyName("platform_discount")]
            public double? PlatformDiscount { get; set; }

            /// <summary>
            /// 邮费，单位：元
            /// </summary>
            [JsonPropertyName("postage")]
            public double? Postage { get; set; }

            /// <summary>
            /// 售后状态
            /// </summary>
            [JsonPropertyName("refund_status")]
            public int? RefundStatus { get; set; }

            /// <summary>
            /// 订单审核状态（0-正常订单， 1-审核中订单）
            /// </summary>
            [JsonPropertyName("risk_control_status")]
            public int? RiskControlStatus { get; set; }

            /// <summary>
            /// 商家优惠金额，单位：元
            /// </summary>
            [JsonPropertyName("seller_discount")]
            public double? SellerDiscount { get; set; }

            /// <summary>
            /// { "step_discount_amount":4, "advanced_paid_fee":1, "step_paid_fee":1.1, "step_trade_status":2 }
            /// </summary>
            [JsonPropertyName("step_order_info")]
            public StepOrderInfoResponse StepOrderInfo { get; set; }

            /// <summary>
            /// 订单类型 0-普通订单 ，1- 定金订单
            /// </summary>
            [JsonPropertyName("trade_type")]
            public int? TradeType { get; set; }

            /// <summary>
            /// 订单的更新时间
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }
            public partial class ItemListResponse : PddResponseModel
            {

                /// <summary>
                /// 商品数量
                /// </summary>
                [JsonPropertyName("goods_count")]
                public int? GoodsCount { get; set; }

                /// <summary>
                /// 商品编码
                /// </summary>
                [JsonPropertyName("goods_id")]
                public string GoodsId { get; set; }

                /// <summary>
                /// 商品图片
                /// </summary>
                [JsonPropertyName("goods_img")]
                public string GoodsImg { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 商品单件 单价：元
                /// </summary>
                [JsonPropertyName("goods_price")]
                public double? GoodsPrice { get; set; }

                /// <summary>
                /// 商品规格
                /// </summary>
                [JsonPropertyName("goods_spec")]
                public string GoodsSpec { get; set; }

                /// <summary>
                /// 商品维度外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                /// </summary>
                [JsonPropertyName("outer_goods_id")]
                public string OuterGoodsId { get; set; }

                /// <summary>
                /// sku维度商家外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; }

                /// <summary>
                /// 商品sku编码
                /// </summary>
                [JsonPropertyName("sku_id")]
                public string SkuId { get; set; }

            }
            public partial class StepOrderInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 已付定金 单位：元
                /// </summary>
                [JsonPropertyName("advanced_paid_fee")]
                public double? AdvancedPaidFee { get; set; }

                /// <summary>
                /// 膨胀金额 单位：元
                /// </summary>
                [JsonPropertyName("step_discount_amount")]
                public double? StepDiscountAmount { get; set; }

                /// <summary>
                /// 分阶段已付金额 单位：元
                /// </summary>
                [JsonPropertyName("step_paid_fee")]
                public double? StepPaidFee { get; set; }

                /// <summary>
                /// 定金订单状态：step_trade_status 枚举：0-定金未付尾款未付、1-定金已付尾款未付、2-定金已付尾款已付
                /// </summary>
                [JsonPropertyName("step_trade_status")]
                public int? StepTradeStatus { get; set; }

            }

        }

    }

}

