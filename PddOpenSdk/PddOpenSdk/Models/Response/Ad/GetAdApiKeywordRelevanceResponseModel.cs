using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdApiKeywordRelevanceResponseModel : PddResponseModel
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
                /// 相关性指标，5最高，值越大相关度越高
                /// </summary>
                [JsonProperty("relevance")]
                public int? Relevance { get; set; }
                /// <summary>
                /// 关键词
                /// </summary>
                [JsonProperty("word")]
                public string Word { get; set; }

            }

        }

    }

}
