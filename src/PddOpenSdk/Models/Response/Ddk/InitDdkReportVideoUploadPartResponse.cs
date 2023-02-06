namespace PddOpenSdk.Models.Response.Ddk;
public partial class InitDdkReportVideoUploadPartResponse : PddResponseModel
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
        [JsonPropertyName("upload_sign")]
        public string UploadSign { get; set; }

    }

}

