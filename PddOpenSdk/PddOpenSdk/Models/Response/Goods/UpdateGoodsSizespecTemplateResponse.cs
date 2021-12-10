namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsSizespecTemplateResponse : PddResponseModel
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
        /// 更新成功
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

