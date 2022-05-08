namespace PddOpenSdk.Models.Response.Ddk;
public partial class QueryDdkCashgiftDataResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("cashgift_data_response")]
    public CashgiftDataResponseResponse CashgiftDataResponse { get; set; }
    public partial class CashgiftDataResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 礼金账户余额，单位为分
        /// </summary>
        [JsonPropertyName("available_balance")]
        public long? AvailableBalance { get; set; }

        /// <summary>
        /// 多多礼金数据列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }

        /// <summary>
        /// 请求到的结果数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 礼金券创建总金额，单位为分
            /// </summary>
            [JsonPropertyName("amount")]
            public long? Amount { get; set; }

            /// <summary>
            /// 礼金ID
            /// </summary>
            [JsonPropertyName("cash_gift_id")]
            public long? CashGiftId { get; set; }

            /// <summary>
            /// 礼金名称
            /// </summary>
            [JsonPropertyName("cash_gift_name")]
            public string CashGiftName { get; set; }

            /// <summary>
            /// 礼金券面额
            /// </summary>
            [JsonPropertyName("couponAmount")]
            public int? CouponAmount { get; set; }

            /// <summary>
            /// 已领取礼金券总金额，单位为分（实时数据）
            /// </summary>
            [JsonPropertyName("fetch_amount")]
            public long? FetchAmount { get; set; }

            /// <summary>
            /// 已领取礼金券数量（实时数据）
            /// </summary>
            [JsonPropertyName("fetch_quantity")]
            public int? FetchQuantity { get; set; }

            /// <summary>
            /// 商品列表信息
            /// </summary>
            [JsonPropertyName("goods_info_list")]
            public List<GoodsInfoListResponse> GoodsInfoList { get; set; }

            /// <summary>
            /// 礼金订单使用的券总金额，单位为分（实时数据）
            /// </summary>
            [JsonPropertyName("order_coupon_amount")]
            public long? OrderCouponAmount { get; set; }

            /// <summary>
            /// 礼金订单产生的总GMV，单位为分（实时数据）
            /// </summary>
            [JsonPropertyName("order_gmv")]
            public long? OrderGmv { get; set; }

            /// <summary>
            /// 礼金订单数量（实时数据）
            /// </summary>
            [JsonPropertyName("order_quantity")]
            public int? OrderQuantity { get; set; }

            /// <summary>
            /// 礼金订单预估佣金，单位为分（实时数据）
            /// </summary>
            [JsonPropertyName("pre_promotion_amount")]
            public long? PrePromotionAmount { get; set; }

            /// <summary>
            /// 礼金券创建总数量
            /// </summary>
            [JsonPropertyName("quantity")]
            public int? Quantity { get; set; }

            /// <summary>
            /// 退回礼金券总金额，单位为分
            /// </summary>
            [JsonPropertyName("refund_amount")]
            public long? RefundAmount { get; set; }

            /// <summary>
            /// 退回礼金券数量
            /// </summary>
            [JsonPropertyName("refund_quantity")]
            public int? RefundQuantity { get; set; }

            /// <summary>
            /// 礼金状态：1-未生效；2-生效中；3-已过期；4-活动中止（用户主动停止）；5-活动中止（佣金降低）；6-活动中止（推广活动异常）
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }
            public partial class GoodsInfoListResponse : PddResponseModel
            {

                /// <summary>
                /// 商品优惠券面额，单位为分
                /// </summary>
                [JsonPropertyName("coupon_discount")]
                public long? CouponDiscount { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 商品原价，单位为分
                /// </summary>
                [JsonPropertyName("goods_price")]
                public long? GoodsPrice { get; set; }

                /// <summary>
                /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
                /// </summary>
                [JsonPropertyName("goods_sign")]
                public string GoodsSign { get; set; }

                /// <summary>
                /// 商品佣金比例，千分比
                /// </summary>
                [JsonPropertyName("rate")]
                public int? Rate { get; set; }

            }

        }

    }

}

