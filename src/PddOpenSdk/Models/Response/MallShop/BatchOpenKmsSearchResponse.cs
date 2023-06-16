namespace PddOpenSdk.Models.Response.MallShop;
public partial class BatchOpenKmsSearchResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_kms_search_batch_response")]
    public OpenKmsSearchBatchResponseResponse OpenKmsSearchBatchResponse { get; set; }
    public partial class OpenKmsSearchBatchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("search_text_list")]
        public List<SearchTextListResponse> SearchTextList { get; set; }
        public partial class SearchTextListResponse : PddResponseModel
        {

            /// <summary>
            /// 输入的搜索内容
            /// </summary>
            [JsonPropertyName("input")]
            public string Input { get; set; }

            /// <summary>
            /// search_text
            /// </summary>
            [JsonPropertyName("search_text")]
            public string SearchText { get; set; }

            /// <summary>
            /// success
            /// </summary>
            [JsonPropertyName("success")]
            public bool? Success { get; set; }

            /// <summary>
            /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; }

        }

    }

}

