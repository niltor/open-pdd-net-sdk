namespace PddOpenSdk.Models.Response.Ad;
public partial class ListAdApiUnitBidQueryTargetingTagResponse : PddResponseModel
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
            /// 标签描述
            /// </summary>
            [JsonPropertyName("description")]
            public string Description { get; set; }

            /// <summary>
            /// 父标签Id
            /// </summary>
            [JsonPropertyName("parentTagId")]
            public string ParentTagId { get; set; }

            /// <summary>
            /// 标签Id
            /// </summary>
            [JsonPropertyName("tagId")]
            public string TagId { get; set; }

            /// <summary>
            /// 定向标签类型，1-地域定向
            /// </summary>
            [JsonPropertyName("tagType")]
            public int? TagType { get; set; }

        }

    }

}

