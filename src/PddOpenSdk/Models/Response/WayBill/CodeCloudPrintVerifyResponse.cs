namespace PddOpenSdk.Models.Response.WayBill;
public partial class CodeCloudPrintVerifyResponse : PddResponseModel
{

    /// <summary>
    /// 云打印验证码响应
    /// </summary>
    [JsonPropertyName("cloud_print_verify_code_response")]
    public CloudPrintVerifyCodeResponseResponse CloudPrintVerifyCodeResponse { get; set; }
    public partial class CloudPrintVerifyCodeResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// true:请求验证码成功 false:请求验证码失败
            /// </summary>
            [JsonPropertyName("result")]
            public bool? Result { get; set; }

        }

    }

}

