namespace PddOpenSdk.Models.Request.WayBill;
public partial class CodeCloudPrintVerify
{

    /// <summary>
    /// 云打印验证码请求
    /// </summary>
    [JsonPropertyName("cloud_print_verify_code_request")]
    public CloudPrintVerifyCodeRequestModel CloudPrintVerifyCodeRequest { get; set; }
    public partial class CloudPrintVerifyCodeRequestModel
    {

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

    }

}

