namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class InfoServiceMailCheckWeightResponse : PddResponseModel
{

    /// <summary>
    /// 返回结果
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 同步结果
        /// </summary>
        [JsonPropertyName("flag")]
        public bool? Flag { get; set; }

    }

}

