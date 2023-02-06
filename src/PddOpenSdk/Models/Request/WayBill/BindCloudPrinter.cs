namespace PddOpenSdk.Models.Request.WayBill;
public partial class BindCloudPrinter
{

    /// <summary>
    /// 云打印绑定请求
    /// </summary>
    [JsonPropertyName("cloud_printer_bind_request")]
    public CloudPrinterBindRequestModel CloudPrinterBindRequest { get; set; }
    public partial class CloudPrinterBindRequestModel
    {

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [JsonPropertyName("verify_code")]
        public string VerifyCode { get; set; }

    }

}

