namespace PddOpenSdk.Models.Request.WayBill;
public partial class SettingCloudPrinter
{

    /// <summary>
    /// 开平请求基类
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 打印浓度（1-淡，2-正常，3-浓）
        /// </summary>
        [JsonPropertyName("density")]
        public int Density { get; set; }

        /// <summary>
        /// 打印机标识
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 共享码
        /// </summary>
        [JsonPropertyName("share_code")]
        public string ShareCode { get; set; }

    }

}

