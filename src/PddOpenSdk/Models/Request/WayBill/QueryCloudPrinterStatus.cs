namespace PddOpenSdk.Models.Request.WayBill;
public partial class QueryCloudPrinterStatus
{

    /// <summary>
    /// 打印状态查询请求
    /// </summary>
    [JsonPropertyName("cloud_printer_status_query_request")]
    public CloudPrinterStatusQueryRequestModel CloudPrinterStatusQueryRequest { get; set; }
    public partial class CloudPrinterStatusQueryRequestModel
    {

        /// <summary>
        /// 打印机id
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

