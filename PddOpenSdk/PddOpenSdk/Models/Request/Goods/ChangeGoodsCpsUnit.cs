namespace PddOpenSdk.Models.Request.Goods;
public partial class ChangeGoodsCpsUnit
{

    /// <summary>
    /// 优惠券结束时间
    /// </summary>
    [JsonPropertyName("coupon_end_time")]
    public string CouponEndTime { get; set; }

    /// <summary>
    /// 优惠券id
    /// </summary>
    [JsonPropertyName("coupon_id")]
    public long? CouponId { get; set; }

    /// <summary>
    /// 优惠券号
    /// </summary>
    [JsonPropertyName("coupon_sn")]
    public string CouponSn { get; set; }

    /// <summary>
    /// 优惠券开始时间
    /// </summary>
    [JsonPropertyName("coupon_start_time")]
    public string CouponStartTime { get; set; }

    /// <summary>
    /// 优惠券面额（单位为分）
    /// </summary>
    [JsonPropertyName("discount")]
    public int? Discount { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 设置的优惠券张数
    /// </summary>
    [JsonPropertyName("init_quantity")]
    public long? InitQuantity { get; set; }

    /// <summary>
    /// 佣金比例（千分比）
    /// </summary>
    [JsonPropertyName("rate")]
    public int Rate { get; set; }

    /// <summary>
    /// 优惠券剩余数量
    /// </summary>
    [JsonPropertyName("remain_quantity")]
    public long? RemainQuantity { get; set; }

    /// <summary>
    /// 优惠券领取后的有效使用时间天数
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

}

