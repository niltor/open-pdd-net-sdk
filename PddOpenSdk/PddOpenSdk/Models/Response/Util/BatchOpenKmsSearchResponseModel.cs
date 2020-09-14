using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class BatchOpenKmsSearchResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_kms_search_batch_response")]
        public OpenKmsSearchBatchResponseResponseModel OpenKmsSearchBatchResponse { get; set; }
        public partial class OpenKmsSearchBatchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("search_text_list")]
            public List<SearchTextListResponseModel> SearchTextList { get; set; }
            public partial class SearchTextListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 输入的搜索内容
                /// </summary>
                [JsonProperty("input")]
                public string Input { get; set; }
                /// <summary>
                /// search_text
                /// </summary>
                [JsonProperty("search_text")]
                public string SearchText { get; set; }
                /// <summary>
                /// success
                /// </summary>
                [JsonProperty("success")]
                public bool? Success { get; set; }
                /// <summary>
                /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
                /// </summary>
                [JsonProperty("type")]
                public string Type { get; set; }

            }

        }

    }

}
