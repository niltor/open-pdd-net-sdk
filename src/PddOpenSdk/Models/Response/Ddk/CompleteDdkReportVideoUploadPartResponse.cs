namespace PddOpenSdk.Models.Response.Ddk;
public partial class CompleteDdkReportVideoUploadPartResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 创建的视频资源对应的vid
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

