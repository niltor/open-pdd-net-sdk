namespace PddOpenSdk.Models.Response.Ddk;
public partial class UploadDdkReportImgResponse : PddResponseModel
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
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

