using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdApiKeywordRecommendResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 关键词平均出价
                /// </summary>
                [JsonProperty("avgBid")]
                public double? AvgBid { get; set; }
                /// <summary>
                /// 竞争力
                /// </summary>
                [JsonProperty("compete")]
                public double? Compete { get; set; }
                /// <summary>
                /// 热度
                /// </summary>
                [JsonProperty("heat")]
                public double? Heat { get; set; }
                /// <summary>
                /// 关键词相关性
                /// </summary>
                [JsonProperty("relevance")]
                public int? Relevance { get; set; }
                /// <summary>
                /// 质量分
                /// </summary>
                [JsonProperty("score")]
                public double? Score { get; set; }
                /// <summary>
                /// 关键词趋势
                /// </summary>
                [JsonProperty("trend")]
                public double? Trend { get; set; }
                /// <summary>
                /// 关键词
                /// </summary>
                [JsonProperty("word")]
                public string Word { get; set; }

            }

        }

    }

}
