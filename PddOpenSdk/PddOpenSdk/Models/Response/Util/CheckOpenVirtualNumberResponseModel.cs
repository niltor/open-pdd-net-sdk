using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class CheckOpenVirtualNumberResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("open_virtual_number_check_response")]
        public OpenVirtualNumberCheckResponseResponseModel OpenVirtualNumberCheckResponse { get; set; }
        public partial class OpenVirtualNumberCheckResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 虚拟号绑定的时间戳
                /// </summary>
                [JsonProperty("bind_timestamp")]
                public long? BindTimestamp { get; set; }
                /// <summary>
                /// 错误码, 0:成功
                /// </summary>
                [JsonProperty("error_code")]
                public int? ErrorCode { get; set; }
                /// <summary>
                /// 错误信息
                /// </summary>
                [JsonProperty("error_msg")]
                public string ErrorMsg { get; set; }
                /// <summary>
                /// 虚拟号过期的时间戳
                /// </summary>
                [JsonProperty("expired_timestamp")]
                public long? ExpiredTimestamp { get; set; }
                /// <summary>
                /// 是否订单所绑定的虚拟号，true是，false否
                /// </summary>
                [JsonProperty("match")]
                public bool? Match { get; set; }
                /// <summary>
                /// 11位入参号码是否是虚拟号
                /// </summary>
                [JsonProperty("virtual")]
                public bool? Virtual { get; set; }

            }

        }

    }

}
