using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ticket
{
    public partial class AddTicketSkuRuleRequestModel : PddRequestModel
    {
        /// <summary>
        /// 下单人信息设置
        /// </summary>
        [JsonProperty("booker_info_limitation")]
        public BookerInfoLimitationRequestModel BookerInfoLimitation { get; set; }
        /// <summary>
        /// 预定须知
        /// </summary>
        [JsonProperty("booking_notice")]
        public BookingNoticeRequestModel BookingNotice { get; set; }
        /// <summary>
        /// 下单限制
        /// </summary>
        [JsonProperty("order_limitation")]
        public OrderLimitationRequestModel OrderLimitation { get; set; }
        /// <summary>
        /// 商户rule ID
        /// </summary>
        [JsonProperty("out_rule_id")]
        public string OutRuleId { get; set; }
        /// <summary>
        /// 服务商联系方式
        /// </summary>
        [JsonProperty("provider_contact_info")]
        public ProviderContactInfoRequestModel ProviderContactInfo { get; set; }
        /// <summary>
        /// 退款规则
        /// </summary>
        [JsonProperty("refund_limitations")]
        public RefundLimitationsRequestModel RefundLimitations { get; set; }
        /// <summary>
        /// 商户rule 名称
        /// </summary>
        [JsonProperty("rule_name")]
        public string RuleName { get; set; }
        /// <summary>
        /// 游玩人信息
        /// </summary>
        [JsonProperty("traveler_info_limitation")]
        public TravelerInfoLimitationRequestModel TravelerInfoLimitation { get; set; }
        /// <summary>
        /// 卡券有效期设置
        /// </summary>
        [JsonProperty("valid_limitation")]
        public ValidLimitationRequestModel ValidLimitation { get; set; }
        public partial class BookerInfoLimitationRequestModel : PddRequestModel
        {
            /// <summary>
            /// 需要下单人信息
            /// </summary>
            [JsonProperty("booker_required")]
            public int BookerRequired { get; set; }
            /// <summary>
            /// 下单人手机
            /// </summary>
            [JsonProperty("mobile")]
            public int? Mobile { get; set; }

        }
        public partial class BookingNoticeRequestModel : PddRequestModel
        {
            /// <summary>
            /// 入园地址
            /// </summary>
            [JsonProperty("enter_address")]
            public string EnterAddress { get; set; }
            /// <summary>
            /// 入园时间
            /// </summary>
            [JsonProperty("enter_time")]
            public List<EnterTimeRequestModel> EnterTime { get; set; }
            /// <summary>
            /// 入园方式
            /// </summary>
            [JsonProperty("enter_ways")]
            public string EnterWays { get; set; }
            /// <summary>
            /// 补充说明
            /// </summary>
            [JsonProperty("extra_desc")]
            public string ExtraDesc { get; set; }
            /// <summary>
            /// 费用包含
            /// </summary>
            [JsonProperty("fee_include")]
            public string FeeInclude { get; set; }
            /// <summary>
            /// 费用不包含
            /// </summary>
            [JsonProperty("fee_not_include")]
            public string FeeNotInclude { get; set; }
            /// <summary>
            /// 重要提示
            /// </summary>
            [JsonProperty("important_notice")]
            public string ImportantNotice { get; set; }
            /// <summary>
            /// 通关限制时间
            /// </summary>
            [JsonProperty("pass_time_limit")]
            public int? PassTimeLimit { get; set; }
            /// <summary>
            /// 换票地址
            /// </summary>
            [JsonProperty("ticket_place")]
            public string TicketPlace { get; set; }
            /// <summary>
            /// 换票时间
            /// </summary>
            [JsonProperty("ticket_time")]
            public List<TicketTimeRequestModel> TicketTime { get; set; }
            public partial class EnterTimeRequestModel : PddRequestModel
            {
                /// <summary>
                /// 备注
                /// </summary>
                [JsonProperty("comment")]
                public string Comment { get; set; }
                /// <summary>
                /// 入园结束时间
                /// </summary>
                [JsonProperty("end_at")]
                public string EndAt { get; set; }
                /// <summary>
                /// 入园开始时间
                /// </summary>
                [JsonProperty("start_at")]
                public string StartAt { get; set; }

            }
            public partial class TicketTimeRequestModel : PddRequestModel
            {
                /// <summary>
                /// 备注
                /// </summary>
                [JsonProperty("comment")]
                public string Comment { get; set; }
                /// <summary>
                /// 换票结束时间
                /// </summary>
                [JsonProperty("end_at")]
                public string EndAt { get; set; }
                /// <summary>
                /// 换票开始时间
                /// </summary>
                [JsonProperty("start_at")]
                public string StartAt { get; set; }

            }

        }
        public partial class OrderLimitationRequestModel : PddRequestModel
        {
            /// <summary>
            /// 周期长度
            /// </summary>
            [JsonProperty("cycle_length")]
            public int? CycleLength { get; set; }
            /// <summary>
            /// 限制类型
            /// </summary>
            [JsonProperty("limitation_type")]
            public int? LimitationType { get; set; }
            /// <summary>
            /// 周期类型
            /// </summary>
            [JsonProperty("limit_cycle")]
            public int? LimitCycle { get; set; }
            /// <summary>
            /// 限购数量
            /// </summary>
            [JsonProperty("limit_num")]
            public int? LimitNum { get; set; }

        }
        public partial class ProviderContactInfoRequestModel : PddRequestModel
        {
            /// <summary>
            /// 服务时间
            /// </summary>
            [JsonProperty("provider_business_hour")]
            public List<ProviderBusinessHourRequestModel> ProviderBusinessHour { get; set; }
            /// <summary>
            /// 服务商名称
            /// </summary>
            [JsonProperty("provider_name")]
            public string ProviderName { get; set; }
            /// <summary>
            /// 服务商联系电话
            /// </summary>
            [JsonProperty("provider_telephone")]
            public string ProviderTelephone { get; set; }
            public partial class ProviderBusinessHourRequestModel : PddRequestModel
            {
                /// <summary>
                /// 结束时间
                /// </summary>
                [JsonProperty("close_at")]
                public string CloseAt { get; set; }
                /// <summary>
                /// 开始时间
                /// </summary>
                [JsonProperty("open_at")]
                public string OpenAt { get; set; }
                /// <summary>
                /// 描述
                /// </summary>
                [JsonProperty("time_info")]
                public string TimeInfo { get; set; }

            }

        }
        public partial class RefundLimitationsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 是否可退
            /// </summary>
            [JsonProperty("is_refundable")]
            public int IsRefundable { get; set; }
            /// <summary>
            /// 退款规则
            /// </summary>
            [JsonProperty("refund_rules")]
            public List<RefundRulesRequestModel> RefundRules { get; set; }
            public partial class RefundRulesRequestModel : PddRequestModel
            {
                /// <summary>
                /// 游玩日 0 点提前 或之后分钟数
                /// </summary>
                [JsonProperty("ahead_time")]
                public int? AheadTime { get; set; }
                /// <summary>
                /// 扣费值
                /// </summary>
                [JsonProperty("deduction_fee")]
                public int DeductionFee { get; set; }
                /// <summary>
                /// 费率单位
                /// </summary>
                [JsonProperty("deduction_unit")]
                public int DeductionUnit { get; set; }
                /// <summary>
                /// 规则类型
                /// </summary>
                [JsonProperty("type")]
                public int Type { get; set; }

            }

        }
        public partial class TravelerInfoLimitationRequestModel : PddRequestModel
        {
            /// <summary>
            /// 游玩人证件
            /// </summary>
            [JsonProperty("credential")]
            public int? Credential { get; set; }
            /// <summary>
            /// 游玩人名字
            /// </summary>
            [JsonProperty("name")]
            public int? Name { get; set; }
            /// <summary>
            /// 出游人信息设置
            /// </summary>
            [JsonProperty("traveler_required")]
            public int TravelerRequired { get; set; }

        }
        public partial class ValidLimitationRequestModel : PddRequestModel
        {
            /// <summary>
            /// 天数内有效
            /// </summary>
            [JsonProperty("days_time")]
            public int? DaysTime { get; set; }
            /// <summary>
            /// 结束时间
            /// </summary>
            [JsonProperty("end_time")]
            public long? EndTime { get; set; }
            /// <summary>
            /// 开始时间
            /// </summary>
            [JsonProperty("start_time")]
            public long? StartTime { get; set; }
            /// <summary>
            /// 有效期时间类型
            /// </summary>
            [JsonProperty("time_type")]
            public int TimeType { get; set; }

        }

    }

}
