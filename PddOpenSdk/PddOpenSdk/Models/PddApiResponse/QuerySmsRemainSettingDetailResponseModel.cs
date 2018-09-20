using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsRemainSettingDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_setting_detail_query_response")]
        public SmsRemainSettingDetailQueryResponseResponseModel SmsRemainSettingDetailQueryResponse { get; set; }

        public partial class SmsRemainSettingDetailQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("success")]
            public bool Success { get; set; }
            /// <summary>
            /// 错误代码
            /// </summary>
            [JsonProperty("error_code")]
            public string ErrorCode { get; set; }
            /// <summary>
            /// 错误类型
            /// </summary>
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }

            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public string MallId { get; set; }
                /// <summary>
                /// 设置类型
                /// </summary>
                [JsonProperty("scene")]
                public int Scene { get; set; }
                /// <summary>
                /// 触发状态
                /// </summary>
                [JsonProperty("trigger_condition")]
                public TriggerConditionResponseModel TriggerCondition { get; set; }
                /// <summary>
                /// 目标
                /// </summary>
                [JsonProperty("target")]
                public TargetResponseModel Target { get; set; }
                /// <summary>
                /// 模板id
                /// </summary>
                [JsonProperty("template_id")]
                public int TemplateId { get; set; }
                /// <summary>
                /// 是否开启
                /// </summary>
                [JsonProperty("open")]
                public int Open { get; set; }
                /// <summary>
                /// 全部条数
                /// </summary>
                [JsonProperty("send_num")]
                public int SendNum { get; set; }
                /// <summary>
                /// 失败条数
                /// </summary>
                [JsonProperty("send_failed_num")]
                public int SendFailedNum { get; set; }

                public partial class TriggerConditionResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 距离系统自动取消订单，单位分钟
                    /// </summary>
                    [JsonProperty("unpaid_duration")]
                    public int UnpaidDuration { get; set; }

                }

                public partial class TargetResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商家实收金额，最低价
                    /// </summary>
                    [JsonProperty("min_pay_amount")]
                    public int MinPayAmount { get; set; }
                    /// <summary>
                    /// 商家实收金额，最高价
                    /// </summary>
                    [JsonProperty("max_pay_amount")]
                    public int MaxPayAmount { get; set; }
                    /// <summary>
                    /// 支付金额是否不限
                    /// </summary>
                    [JsonProperty("pay_amount_limit")]
                    public int PayAmountLimit { get; set; }
                    /// <summary>
                    /// 地区类型
                    /// </summary>
                    [JsonProperty("region_type")]
                    public int RegionType { get; set; }
                    /// <summary>
                    /// 收货地区
                    /// </summary>
                    [JsonProperty("region")]
                    public int Region { get; set; }
                    /// <summary>
                    /// 商品id列表
                    /// </summary>
                    [JsonProperty("goods")]
                    public string Goods { get; set; }
                    /// <summary>
                    /// 是否排除商品
                    /// </summary>
                    [JsonProperty("goods_invert")]
                    public int GoodsInvert { get; set; }

                }

            }

        }

    }
}
