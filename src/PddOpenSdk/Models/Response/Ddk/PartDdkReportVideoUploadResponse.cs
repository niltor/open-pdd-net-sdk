namespace PddOpenSdk.Models.Response.Ddk;
public partial class PartDdkReportVideoUploadResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 表示本次成功上传的part number
        /// </summary>
        [JsonPropertyName("uploaded_part_num")]
        public int? UploadedPartNum { get; set; }

    }

}

