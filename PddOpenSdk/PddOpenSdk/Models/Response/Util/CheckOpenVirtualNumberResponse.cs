namespace PddOpenSdk.Models.Response.Util;
public partial class CheckOpenVirtualNumberResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("open_virtual_number_check_response")]
    public OpenVirtualNumberCheckResponseResponse OpenVirtualNumberCheckResponse { get; set; }
    public partial class OpenVirtualNumberCheckResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 虚拟号绑定的时间戳
            /// </summary>
            [JsonPropertyName("bind_timestamp")]
            public long? BindTimestamp { get; set; }

            /// <summary>
            /// 错误码, 0:成功
            /// </summary>
            [JsonPropertyName("error_code")]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [JsonPropertyName("error_msg")]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// 虚拟号过期的时间戳
            /// </summary>
            [JsonPropertyName("expired_timestamp")]
            public long? ExpiredTimestamp { get; set; }

            /// <summary>
            /// 是否订单所绑定的虚拟号，true是，false否
            /// </summary>
            [JsonPropertyName("match")]
            public bool? Match { get; set; }

            /// <summary>
            /// 11位入参号码是否是虚拟号
            /// </summary>
            [JsonPropertyName("virtual")]
            public bool? Virtual { get; set; }

        }

    }

}

