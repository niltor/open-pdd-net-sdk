namespace PddOpenSdk.Models.Request.Order;
public partial class CancelRdcPddgeniusSendgoods
{

    /// <summary>
    /// param
    /// </summary>
    [JsonPropertyName("param")]
    public ParamModel Param { get; set; }
    public partial class ParamModel
    {

        /// <summary>
        /// 错误码：1001 错误场景：该订单未同步，无法取消发货 实际含义：订单未同步到isv; 错误码：1002 错误场景：该订单已发货，无法取消发货 实际含义：订单已经发货; 错误码：1003 错误场景：该订单已发货，无法取消发货 实际含义：订单已打印电子面单
        /// </summary>
        [JsonPropertyName("fail_reason_code")]
        public int? FailReasonCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 操作时间戳（毫秒）
        /// </summary>
        [JsonPropertyName("operate_time")]
        public long? OperateTime { get; set; }

        /// <summary>
        /// 退款金额 单位 分
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public int? RefundFee { get; set; }

        /// <summary>
        /// 退款单ID
        /// </summary>
        [JsonPropertyName("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 状态SUCCESS、FAIL
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("tid")]
        public string Tid { get; set; }

    }

}

