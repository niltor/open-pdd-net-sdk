namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSizespecClassResponse : PddResponseModel
{

    /// <summary>
    /// 响应
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 尺码表叶分类（二级分类）
            /// </summary>
            [JsonPropertyName("children")]
            public List<ChildrenResponse> Children { get; set; }

            /// <summary>
            /// 尺码表分类id
            /// </summary>
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            /// <summary>
            /// 尺码表分类名称
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }
            public partial class ChildrenResponse : PddResponseModel
            {

                /// <summary>
                /// 尺码表分类id
                /// </summary>
                [JsonPropertyName("id")]
                public int? Id { get; set; }

                /// <summary>
                /// 尺码表分类名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

            }

        }

    }

}

