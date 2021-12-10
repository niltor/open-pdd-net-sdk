namespace PddOpenSdk.Models.Response.Order;
public partial class AddressOrderUpdateResponse : PddResponseModel
{

    /// <summary>
    /// 请求响应
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 请求返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 提示文案
            /// </summary>
            [JsonPropertyName("msg")]
            public string Msg { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

        }

    }

}

