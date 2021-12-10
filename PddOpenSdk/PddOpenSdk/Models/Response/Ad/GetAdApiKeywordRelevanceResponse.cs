namespace PddOpenSdk.Models.Response.Ad;
public partial class GetAdApiKeywordRelevanceResponse : PddResponseModel
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
            /// 相关性指标，5最高，值越大相关度越高
            /// </summary>
            [JsonPropertyName("relevance")]
            public int? Relevance { get; set; }

            /// <summary>
            /// 关键词
            /// </summary>
            [JsonPropertyName("word")]
            public string Word { get; set; }

        }

    }

}

