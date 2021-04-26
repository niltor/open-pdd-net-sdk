using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Order
{
    public partial class UpdateOrderNoteResponseModel : PddResponseModel
    {
        /// <summary>
        /// 请求响应
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否请求成功
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            /// <summary>
            /// 错误码
            /// </summary>
            [JsonProperty("error_code")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 错误信息
            /// </summary>
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }

        }

    }

}
