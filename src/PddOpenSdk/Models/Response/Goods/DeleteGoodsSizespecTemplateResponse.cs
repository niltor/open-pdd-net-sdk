namespace PddOpenSdk.Models.Response.Goods;
public partial class DeleteGoodsSizespecTemplateResponse : PddResponseModel
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
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 删除成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

