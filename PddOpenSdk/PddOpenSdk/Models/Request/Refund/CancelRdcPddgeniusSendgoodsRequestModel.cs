using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Refund
{
    public partial class CancelRdcPddgeniusSendgoodsRequestModel : PddRequestModel {
        /// <summary>
        /// param
        /// </summary>
        [JsonProperty ("param")]
        public ParamRequestModel Param { get; set; }
        public partial class ParamRequestModel : PddRequestModel {
            /// <summary>
            /// 操作时间戳（毫秒）
            /// </summary>
            [JsonProperty ("operate_time")]
            public long? OperateTime { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty ("tid")]
            public string Tid { get; set; }
            /// <summary>
            /// 状态SUCCESS、FAIL
            /// </summary>
            [JsonProperty ("status")]
            public string Status { get; set; }
            /// <summary>
            /// 退款单ID
            /// </summary>
            [JsonProperty ("refund_id")]
            public long RefundId { get; set; }
            /// <summary>
            /// 退款金额 单位 分
            /// </summary>
            [JsonProperty ("refund_fee")]
            public int RefundFee { get; set; }
            /// <summary>
            /// 描述
            /// </summary>
            [JsonProperty ("msg")]
            public string Msg { get; set; }

        }

    }

}