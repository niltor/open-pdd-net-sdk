namespace PddOpenSdk.Models.Response.Logistics;
public partial class PushLogisticsTscOrgSplitCfgResponse : PddResponseModel
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
        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

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
            [JsonPropertyName("object_id")]
            public long? ObjectId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("reason")]
            public string Reason { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("success")]
            public bool? Success { get; set; }

        }

    }

}

