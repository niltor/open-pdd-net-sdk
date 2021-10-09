namespace PddOpenSdk.Models.Response.Goods;
public partial class QueryGoodsCpsUnitResponse : PddResponseModel
{

    /// <summary>
    /// 计划使用的优惠券信息。商品没有优惠券将返回null，有优惠券将返回优惠券信息，包括优惠券起始结束时间，优惠券数量，剩余数量，金额等
    /// </summary>
    [JsonPropertyName("coupon_vo")]
    public CouponVoResponse CouponVo { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long? GoodsId { get; set; }

    /// <summary>
    /// 佣金比例（千分比）
    /// </summary>
    [JsonPropertyName("rate")]
    public int? Rate { get; set; }

    /// <summary>
    /// 即将生效的全店推广计划佣金比（千分比），若没有则为null
    /// </summary>
    [JsonPropertyName("rate_to_be")]
    public int? RateToBe { get; set; }

    /// <summary>
    /// 通用推广计划佣金生效时间
    /// </summary>
    [JsonPropertyName("rate_to_be_day")]
    public string RateToBeDay { get; set; }

    /// <summary>
    /// 商品状态，1-推广中，2-暂停，3-删除
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// 即将生效的全店推广计划状态：1-推广中，2-暂停推广，若没有则为null
    /// </summary>
    [JsonPropertyName("status_to_be")]
    public int? StatusToBe { get; set; }

    /// <summary>
    /// 通用推广计划状态生效时间
    /// </summary>
    [JsonPropertyName("status_to_be_day")]
    public string StatusToBeDay { get; set; }

    /// <summary>
    /// 单品推广计划单元id
    /// </summary>
    [JsonPropertyName("unit_id")]
    public long? UnitId { get; set; }
    public partial class CouponVoResponse : PddResponseModel
    {

        /// <summary>
        /// coupon_end_time
        /// </summary>
        [JsonPropertyName("coupon_end_time")]
        public string CouponEndTime { get; set; }

        /// <summary>
        /// coupon_id
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public long? CouponId { get; set; }

        /// <summary>
        /// coupon_start_time
        /// </summary>
        [JsonPropertyName("coupon_start_time")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// discount
        /// </summary>
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }

        /// <summary>
        /// init_quantity
        /// </summary>
        [JsonPropertyName("init_quantity")]
        public long? InitQuantity { get; set; }

        /// <summary>
        /// remain_quantity
        /// </summary>
        [JsonPropertyName("remain_quantity")]
        public long? RemainQuantity { get; set; }

    }

}

