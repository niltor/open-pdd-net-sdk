namespace PddOpenSdk.Models.Response.Ad;
public partial class GetAdApiKeywordRecommendResponse : PddResponseModel
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
            /// 关键词平均出价
            /// </summary>
            [JsonPropertyName("avgBid")]
            public double? AvgBid { get; set; }

            /// <summary>
            /// 竞争力
            /// </summary>
            [JsonPropertyName("compete")]
            public double? Compete { get; set; }

            /// <summary>
            /// 热度
            /// </summary>
            [JsonPropertyName("heat")]
            public double? Heat { get; set; }

            /// <summary>
            /// 关键词相关性
            /// </summary>
            [JsonPropertyName("relevance")]
            public int? Relevance { get; set; }

            /// <summary>
            /// 质量分
            /// </summary>
            [JsonPropertyName("score")]
            public double? Score { get; set; }

            /// <summary>
            /// 关键词趋势
            /// </summary>
            [JsonPropertyName("trend")]
            public double? Trend { get; set; }

            /// <summary>
            /// 关键词
            /// </summary>
            [JsonPropertyName("word")]
            public string Word { get; set; }

        }

    }

}

