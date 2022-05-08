namespace PddOpenSdk.Models.Request.Ddk;
public partial class CreateDdkCashgift
{

    /// <summary>
    /// 券批次领取结束时间。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("acquire_end_time")]
    public long AcquireEndTime { get; set; }

    /// <summary>
    /// 券批次领取开始时间。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("acquire_start_time")]
    public long AcquireStartTime { get; set; }

    /// <summary>
    /// 是否自动领券，默认false不自动领券
    /// </summary>
    [JsonPropertyName("auto_take")]
    public bool? AutoTake { get; set; }

    /// <summary>
    /// 创建礼金类型：1-普通满减礼金；2-不限商品满减礼金；3-免单礼金；4-灵活面额礼金。默认为普通满减礼金
    /// </summary>
    [JsonPropertyName("cashgift_type")]
    public int? CashgiftType { get; set; }

    /// <summary>
    /// 礼金券面额，单位为分，创建普通满减礼金、不限商品满减礼金和免单礼金时，该字段必填；创建灵活面额礼金时，该字段传空，券面额 = 商品券后价 - 期望礼金券后价，由系统自动计算
    /// </summary>
    [JsonPropertyName("coupon_amount")]
    public int? CouponAmount { get; set; }

    /// <summary>
    /// 满减门槛，单位为分。对于普通满减礼金和不限商品满减礼金，满减门槛至少需为礼金券面额的2倍
    /// </summary>
    [JsonPropertyName("coupon_threshold_amount")]
    public int? CouponThresholdAmount { get; set; }

    /// <summary>
    /// 活动持续时间，validity_time_type为 1 时必填。相对时间类型为天级时，最大值为30，即领取后30天内有效；相对时间类型为小时级时，最大值为24，即领取后24小时内有效；相对时间类型为分钟级时，则最大值为60，即领取后60分钟内有效。
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// 期望礼金券后价，单位为分，最小值为1。创建灵活面额礼金时必填
    /// </summary>
    [JsonPropertyName("except_amount")]
    public int? ExceptAmount { get; set; }

    /// <summary>
    /// 是否打开风控保护开关，默认false关闭
    /// </summary>
    [JsonPropertyName("fetch_risk_check")]
    public bool? FetchRiskCheck { get; set; }

    /// <summary>
    /// 收益保护开关开启(rate_decrease_monitor = true)时必填。0-监控项发生降低；1-监控项低于礼金面额，默认为0。
    /// </summary>
    [JsonPropertyName("freeze_condition")]
    public int? FreezeCondition { get; set; }

    /// <summary>
    /// 收益保护开关开启(rate_decrease_monitor = true)时必填。0-佣金；1-补贴；2-佣金+补贴，默认为0。
    /// </summary>
    [JsonPropertyName("freeze_watch_type")]
    public int? FreezeWatchType { get; set; }

    /// <summary>
    /// 是否开启全场景推广，默认false不开启全场景推广，仅支持普通满减礼金和免单礼金
    /// </summary>
    [JsonPropertyName("generate_global")]
    public bool? GenerateGlobal { get; set; }

    /// <summary>
    /// 商品goodsSign列表，例如：["c9r2omogKFFAc7WBwvbZU1ikIb16_J3CTa8HNN"]，最多可支持传20个商品。创建普通满减礼金、免单礼金和灵活面额礼金时，该字段必填；创建不限商品满减礼金时，该字段传空。goodsSign使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
    /// </summary>
    [JsonPropertyName("goods_sign_list")]
    public List<string> GoodsSignList { get; set; }

    /// <summary>
    /// 活动单链接可领券数量，默认无限制，最小值为1。
    /// </summary>
    [JsonPropertyName("link_acquire_limit")]
    public long? LinkAcquireLimit { get; set; }

    /// <summary>
    /// 礼金名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// 可使用推广位列表，例如：["60005_612"]。(列表中的PID方可推广该礼金)
    /// </summary>
    [JsonPropertyName("p_id_list")]
    public List<string> PIdList { get; set; }

    /// <summary>
    /// 礼金券数量，创建普通满减礼金、不限商品满减礼金或免单礼金时，该字段必填；创建灵活面额礼金时，礼金券数量不固定，礼金总预算用完为止，该字段不传
    /// </summary>
    [JsonPropertyName("quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// 收益保护开关，默认false关闭，仅支持普通满减礼金和免单礼金。开启状态下，系统将根据设置内容进行监控，当监控项满足冻结条件时，系统自动冻结礼金暂停推广，防止资金损失（您可通过多多礼金状态更新接口自行恢复推广）
    /// </summary>
    [JsonPropertyName("rate_decrease_monitor")]
    public bool? RateDecreaseMonitor { get; set; }

    /// <summary>
    /// 相对时间类型：1-天级；2-小时级；3-分钟级，有效期类型validityTimeType = 1时必填，默认为1。 例如: relative_time_type = 2, duration = 15, 表示领取后15小时内有效。
    /// </summary>
    [JsonPropertyName("relative_time_type")]
    public int? RelativeTimeType { get; set; }

    /// <summary>
    /// 礼金总预算，单位为分，创建灵活面额礼金时必填。其他情况，总金额 = 礼金券数量 * 礼金券面额
    /// </summary>
    [JsonPropertyName("total_amount")]
    public long? TotalAmount { get; set; }

    /// <summary>
    /// 单用户可领券数量，可设置范围为1~10张，默认为1张。
    /// </summary>
    [JsonPropertyName("user_limit")]
    public int? UserLimit { get; set; }

    /// <summary>
    /// 券批次使用结束时间, validity_time_type为 2 时必填。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("validity_end_time")]
    public long? ValidityEndTime { get; set; }

    /// <summary>
    /// 券批次使用开始时间, validity_time_type为 2 时必填。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("validity_start_time")]
    public long? ValidityStartTime { get; set; }

    /// <summary>
    /// 有效期类型：1-领取后几天内有效；2-固定时间内有效
    /// </summary>
    [JsonPropertyName("validity_time_type")]
    public int ValidityTimeType { get; set; }

}

