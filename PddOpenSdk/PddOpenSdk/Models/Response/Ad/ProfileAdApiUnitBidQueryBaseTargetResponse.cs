namespace PddOpenSdk.Models.Response.Ad;
public partial class ProfileAdApiUnitBidQueryBaseTargetResponse : PddResponseModel
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
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 定向类型描述
            /// </summary>
            [JsonPropertyName("targetName")]
            public string TargetName { get; set; }

            /// <summary>
            /// 定向类型
            /// </summary>
            [JsonPropertyName("targetType")]
            public int? TargetType { get; set; }

            /// <summary>
            /// 用户数量预估
            /// </summary>
            [JsonPropertyName("uvString")]
            public string UvString { get; set; }

        }

    }

}

