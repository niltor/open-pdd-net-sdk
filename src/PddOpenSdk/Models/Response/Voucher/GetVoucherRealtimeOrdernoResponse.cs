namespace PddOpenSdk.Models.Response.Voucher;
public partial class GetVoucherRealtimeOrdernoResponse : PddResponseModel
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
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 外部订单号
            /// </summary>
            [JsonPropertyName("external_order_no")]
            public string ExternalOrderNo { get; set; }

            /// <summary>
            /// 总可核销次数
            /// </summary>
            [JsonPropertyName("total_times")]
            public int? TotalTimes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("verify_list")]
            public List<VerifyListResponse> VerifyList { get; set; }
            public partial class VerifyListResponse : PddResponseModel
            {

                /// <summary>
                /// 核销流水号
                /// </summary>
                [JsonPropertyName("verify_serial_no")]
                public string VerifySerialNo { get; set; }

                /// <summary>
                /// 核销时间，13位时间戳
                /// </summary>
                [JsonPropertyName("verify_time")]
                public long? VerifyTime { get; set; }

                /// <summary>
                /// 核销次数
                /// </summary>
                [JsonPropertyName("verify_times")]
                public int? VerifyTimes { get; set; }

            }

        }

    }

}

