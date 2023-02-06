namespace PddOpenSdk.Models.Response.WayBill;
public partial class BindCloudPrinterResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("cloud_printer_bind_response")]
    public CloudPrinterBindResponseResponse CloudPrinterBindResponse { get; set; }
    public partial class CloudPrinterBindResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("result")]
            public bool? Result { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("shareCode")]
            public string ShareCode { get; set; }

        }

    }

}

