namespace PddOpenSdk.Models.Request.Ticket;
public partial class AddTicketSkuRule
{

    /// <summary>
    /// 下单人信息设置
    /// </summary>
    [JsonPropertyName("booker_info_limitation")]
    public BookerInfoLimitationModel BookerInfoLimitation { get; set; }

    /// <summary>
    /// 预定须知
    /// </summary>
    [JsonPropertyName("booking_notice")]
    public BookingNoticeModel BookingNotice { get; set; }

    /// <summary>
    /// 下单限制
    /// </summary>
    [JsonPropertyName("order_limitation")]
    public OrderLimitationModel OrderLimitation { get; set; }

    /// <summary>
    /// 商户rule ID
    /// </summary>
    [JsonPropertyName("out_rule_id")]
    public string OutRuleId { get; set; }

    /// <summary>
    /// 服务商联系方式
    /// </summary>
    [JsonPropertyName("provider_contact_info")]
    public ProviderContactInfoModel ProviderContactInfo { get; set; }

    /// <summary>
    /// 退款规则
    /// </summary>
    [JsonPropertyName("refund_limitations")]
    public RefundLimitationsModel RefundLimitations { get; set; }

    /// <summary>
    /// 商户rule 名称
    /// </summary>
    [JsonPropertyName("rule_name")]
    public string RuleName { get; set; }

    /// <summary>
    /// 游玩人信息
    /// </summary>
    [JsonPropertyName("traveler_info_limitation")]
    public TravelerInfoLimitationModel TravelerInfoLimitation { get; set; }

    /// <summary>
    /// 卡券有效期设置
    /// </summary>
    [JsonPropertyName("valid_limitation")]
    public ValidLimitationModel ValidLimitation { get; set; }
    public partial class BookerInfoLimitationModel
    {

        /// <summary>
        /// 需要下单人信息
        /// </summary>
        [JsonPropertyName("booker_required")]
        public int BookerRequired { get; set; }

        /// <summary>
        /// 下单人手机
        /// </summary>
        [JsonPropertyName("mobile")]
        public int? Mobile { get; set; }

    }
    public partial class BookingNoticeModel
    {

        /// <summary>
        /// 入园地址
        /// </summary>
        [JsonPropertyName("enter_address")]
        public string EnterAddress { get; set; }

        /// <summary>
        /// 入园时间
        /// </summary>
        [JsonPropertyName("enter_time")]
        public List<EnterTimeModel> EnterTime { get; set; }

        /// <summary>
        /// 入园方式
        /// </summary>
        [JsonPropertyName("enter_ways")]
        public string EnterWays { get; set; }

        /// <summary>
        /// 补充说明
        /// </summary>
        [JsonPropertyName("extra_desc")]
        public string ExtraDesc { get; set; }

        /// <summary>
        /// 费用包含
        /// </summary>
        [JsonPropertyName("fee_include")]
        public string FeeInclude { get; set; }

        /// <summary>
        /// 费用不包含
        /// </summary>
        [JsonPropertyName("fee_not_include")]
        public string FeeNotInclude { get; set; }

        /// <summary>
        /// 重要提示
        /// </summary>
        [JsonPropertyName("important_notice")]
        public string ImportantNotice { get; set; }

        /// <summary>
        /// 通关限制时间
        /// </summary>
        [JsonPropertyName("pass_time_limit")]
        public int? PassTimeLimit { get; set; }

        /// <summary>
        /// 换票地址
        /// </summary>
        [JsonPropertyName("ticket_place")]
        public string TicketPlace { get; set; }

        /// <summary>
        /// 换票时间
        /// </summary>
        [JsonPropertyName("ticket_time")]
        public List<TicketTimeModel> TicketTime { get; set; }
        public partial class EnterTimeModel
        {

            /// <summary>
            /// 备注
            /// </summary>
            [JsonPropertyName("comment")]
            public string Comment { get; set; }

            /// <summary>
            /// 入园结束时间
            /// </summary>
            [JsonPropertyName("end_at")]
            public string EndAt { get; set; }

            /// <summary>
            /// 入园开始时间
            /// </summary>
            [JsonPropertyName("start_at")]
            public string StartAt { get; set; }

        }
        public partial class TicketTimeModel
        {

            /// <summary>
            /// 备注
            /// </summary>
            [JsonPropertyName("comment")]
            public string Comment { get; set; }

            /// <summary>
            /// 换票结束时间
            /// </summary>
            [JsonPropertyName("end_at")]
            public string EndAt { get; set; }

            /// <summary>
            /// 换票开始时间
            /// </summary>
            [JsonPropertyName("start_at")]
            public string StartAt { get; set; }

        }

    }
    public partial class OrderLimitationModel
    {

        /// <summary>
        /// 周期长度
        /// </summary>
        [JsonPropertyName("cycle_length")]
        public int? CycleLength { get; set; }

        /// <summary>
        /// 限制类型
        /// </summary>
        [JsonPropertyName("limitation_type")]
        public int? LimitationType { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [JsonPropertyName("limit_cycle")]
        public int? LimitCycle { get; set; }

        /// <summary>
        /// 限购数量
        /// </summary>
        [JsonPropertyName("limit_num")]
        public int? LimitNum { get; set; }

    }
    public partial class ProviderContactInfoModel
    {

        /// <summary>
        /// 服务时间
        /// </summary>
        [JsonPropertyName("provider_business_hour")]
        public List<ProviderBusinessHourModel> ProviderBusinessHour { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [JsonPropertyName("provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// 服务商联系电话
        /// </summary>
        [JsonPropertyName("provider_telephone")]
        public string ProviderTelephone { get; set; }
        public partial class ProviderBusinessHourModel
        {

            /// <summary>
            /// 结束时间
            /// </summary>
            [JsonPropertyName("close_at")]
            public string CloseAt { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [JsonPropertyName("open_at")]
            public string OpenAt { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [JsonPropertyName("time_info")]
            public string TimeInfo { get; set; }

        }

    }
    public partial class RefundLimitationsModel
    {

        /// <summary>
        /// 是否可退
        /// </summary>
        [JsonPropertyName("is_refundable")]
        public int IsRefundable { get; set; }

        /// <summary>
        /// 退款规则
        /// </summary>
        [JsonPropertyName("refund_rules")]
        public List<RefundRulesModel> RefundRules { get; set; }
        public partial class RefundRulesModel
        {

            /// <summary>
            /// 游玩日 0 点提前 或之后分钟数
            /// </summary>
            [JsonPropertyName("ahead_time")]
            public int? AheadTime { get; set; }

            /// <summary>
            /// 扣费值
            /// </summary>
            [JsonPropertyName("deduction_fee")]
            public int DeductionFee { get; set; }

            /// <summary>
            /// 费率单位
            /// </summary>
            [JsonPropertyName("deduction_unit")]
            public int DeductionUnit { get; set; }

            /// <summary>
            /// 规则类型
            /// </summary>
            [JsonPropertyName("type")]
            public int Type { get; set; }

        }

    }
    public partial class TravelerInfoLimitationModel
    {

        /// <summary>
        /// 游玩人证件
        /// </summary>
        [JsonPropertyName("credential")]
        public int? Credential { get; set; }

        /// <summary>
        /// 游玩人名字
        /// </summary>
        [JsonPropertyName("name")]
        public int? Name { get; set; }

        /// <summary>
        /// 出游人信息设置
        /// </summary>
        [JsonPropertyName("traveler_required")]
        public int TravelerRequired { get; set; }

    }
    public partial class ValidLimitationModel
    {

        /// <summary>
        /// 天数内有效
        /// </summary>
        [JsonPropertyName("days_time")]
        public int? DaysTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// 有效期时间类型
        /// </summary>
        [JsonPropertyName("time_type")]
        public int TimeType { get; set; }

    }

}

