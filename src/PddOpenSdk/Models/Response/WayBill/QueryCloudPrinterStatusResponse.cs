namespace PddOpenSdk.Models.Response.WayBill;
public partial class QueryCloudPrinterStatusResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
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
            /// 打印机id
            /// </summary>
            [JsonPropertyName("printer_id")]
            public string PrinterId { get; set; }

            /// <summary>
            /// 信号强度dbm
            /// </summary>
            [JsonPropertyName("signal_strength")]
            public string SignalStrength { get; set; }

            /// <summary>
            /// 信号格度0-5,未查询到为null
            /// </summary>
            [JsonPropertyName("signal_strength_friendly")]
            public int? SignalStrengthFriendly { get; set; }

            /// <summary>
            /// 打印机状态 -1:未知  0:未找到打印机  1:不在线  2:在线
            /// </summary>
            [JsonPropertyName("status")]
            public string Status { get; set; }

        }

    }

}

