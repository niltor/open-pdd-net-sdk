namespace PddOpenSdk.Models.Response.Promotion;
public partial class GetPromotionGoodsCouponListResponse : PddResponseModel
{

    /// <summary>
    /// 返回商品优惠券批次表
    /// </summary>
    [JsonPropertyName("goods_coupon_batch_list_response")]
    public GoodsCouponBatchListResponseResponse GoodsCouponBatchListResponse { get; set; }
    public partial class GoodsCouponBatchListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 返回商品优惠券对象
        /// </summary>
        [JsonPropertyName("coupon_batch_list")]
        public List<CouponBatchListResponse> CouponBatchList { get; set; }

        /// <summary>
        /// 返回的优惠券总数
        /// </summary>
        [JsonPropertyName("total_size")]
        public int? TotalSize { get; set; }
        public partial class CouponBatchListResponse : PddResponseModel
        {

            /// <summary>
            /// 批次ID
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 批次描述
            /// </summary>
            [JsonPropertyName("batch_desc")]
            public string BatchDesc { get; set; }

            /// <summary>
            /// 折扣参数，为请求中传入的discountAmount，表示折扣金额，单位: 分
            /// </summary>
            [JsonPropertyName("discount_param")]
            public long? DiscountParam { get; set; }

            /// <summary>
            /// 最小可用订单金额
            /// </summary>
            [JsonPropertyName("min_order_amount")]
            public long? MinOrderAmount { get; set; }

            /// <summary>
            /// 初始数量
            /// </summary>
            [JsonPropertyName("init_quantity")]
            public long? InitQuantity { get; set; }

            /// <summary>
            /// 剩余数量
            /// </summary>
            [JsonPropertyName("remain_quantity")]
            public long? RemainQuantity { get; set; }

            /// <summary>
            /// 已使用数量
            /// </summary>
            [JsonPropertyName("used_quantity")]
            public long? UsedQuantity { get; set; }

            /// <summary>
            /// 用户限领张数，-1 代表不限制
            /// </summary>
            [JsonPropertyName("user_limit")]
            public long? UserLimit { get; set; }

            /// <summary>
            /// 批次开始时间
            /// </summary>
            [JsonPropertyName("batch_start_time")]
            public long? BatchStartTime { get; set; }

            /// <summary>
            /// 批次结束时间
            /// </summary>
            [JsonPropertyName("batch_end_time")]
            public long? BatchEndTime { get; set; }

            /// <summary>
            /// 券来源类型，45 店铺多多进宝商品券，54 无门槛商品券，87 店铺多多进宝大淘客定向商品券，88 店铺多多果园商品券
            /// </summary>
            [JsonPropertyName("source_type")]
            public int? SourceType { get; set; }

            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品名
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 图片URL
            /// </summary>
            [JsonPropertyName("image_url")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 批次状态，1 领取中，2 已领完，3 已结束，4 已暂停
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 批次创建时间
            /// </summary>
            [JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }

        }

    }

}

