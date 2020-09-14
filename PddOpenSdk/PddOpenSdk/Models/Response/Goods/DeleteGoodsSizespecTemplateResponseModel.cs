using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class DeleteGoodsSizespecTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 错误码
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 错误描述
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 删除成功
            /// </summary>
            [JsonProperty("result")]
            public bool? Result { get; set; }
            /// <summary>
            /// 请求成功
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
