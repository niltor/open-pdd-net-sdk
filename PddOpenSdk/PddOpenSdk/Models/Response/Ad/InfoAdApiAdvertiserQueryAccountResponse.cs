namespace PddOpenSdk.Models.Response.Ad;
public partial class InfoAdApiAdvertiserQueryAccountResponse : PddResponseModel
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
            /// 是否已开户
            /// </summary>
            [JsonPropertyName("hasOpenAccount")]
            public bool? HasOpenAccount { get; set; }

            /// <summary>
            /// 是否已缴纳保证金
            /// </summary>
            [JsonPropertyName("hasPaidDeposit")]
            public bool? HasPaidDeposit { get; set; }

            /// <summary>
            /// 是否已签署广告协议
            /// </summary>
            [JsonPropertyName("hasSignProtocol")]
            public bool? HasSignProtocol { get; set; }

            /// <summary>
            /// 广告主ID
            /// </summary>
            [JsonPropertyName("mallId")]
            public long? MallId { get; set; }

        }

    }

}

