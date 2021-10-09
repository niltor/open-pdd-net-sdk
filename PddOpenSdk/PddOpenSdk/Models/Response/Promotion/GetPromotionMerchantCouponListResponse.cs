namespace PddOpenSdk.Models.Response.Promotion;
public partial class GetPromotionMerchantCouponListResponse : PddResponseModel
{

    /// <summary>
    /// 返回店铺优惠券批次列表
    /// </summary>
    [JsonPropertyName("merchant_coupon_batch_list_response")]
    public MerchantCouponBatchListResponseResponse MerchantCouponBatchListResponse { get; set; }
    public partial class MerchantCouponBatchListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 返回店铺优惠券批次数量
        /// </summary>
        [JsonPropertyName("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// 返回店铺优惠券批次对象
        /// </summary>
        [JsonPropertyName("coupon_batch_list")]
        public List<CouponBatchListResponse> CouponBatchList { get; set; }
        public partial class CouponBatchListResponse : PddResponseModel
        {

            /// <summary>
            /// 批次ID
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 批次名
            /// </summary>
            [JsonPropertyName("batch_name")]
            public string BatchName { get; set; }

            /// <summary>
            /// 批次描述
            /// </summary>
            [JsonPropertyName("batch_desc")]
            public string BatchDesc { get; set; }

            /// <summary>
            /// 折扣类型，1 代表满减券，2 代表折扣券
            /// </summary>
            [JsonPropertyName("discount_type")]
            public int? DiscountType { get; set; }

            /// <summary>
            /// 折扣参数，为请求中传入的discount_amount，表示折扣金额，单位: 分
            /// </summary>
            [JsonPropertyName("discount_param")]
            public long? DiscountParam { get; set; }

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
            /// 最大折扣金额
            /// </summary>
            [JsonPropertyName("max_discount_amount")]
            public long? MaxDiscountAmount { get; set; }

            /// <summary>
            /// 券有效时长
            /// </summary>
            [JsonPropertyName("duration")]
            public long? Duration { get; set; }

            /// <summary>
            /// 券有效期时长的单位，0 代表天，2 代表小时
            /// </summary>
            [JsonPropertyName("period_type")]
            public int? PeriodType { get; set; }

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
            /// 券来源类型，16 店铺直接领券，41 店铺精选评价优惠券，66 商家短信营销优惠券
            /// </summary>
            [JsonPropertyName("source_type")]
            public int? SourceType { get; set; }

            /// <summary>
            /// 券类型，固定为8，代表商家券
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// 批次状态，1 领取中，2 已领完，3 已结束
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 用券条件
            /// </summary>
            [JsonPropertyName("rules")]
            public string Rules { get; set; }

            /// <summary>
            /// 券展示类型，固定为8，代表商家券
            /// </summary>
            [JsonPropertyName("display_type")]
            public int? DisplayType { get; set; }

            /// <summary>
            /// 批次创建时间
            /// </summary>
            [JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }

        }

    }

}

