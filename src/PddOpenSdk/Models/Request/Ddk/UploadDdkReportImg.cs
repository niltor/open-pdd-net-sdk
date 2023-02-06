namespace PddOpenSdk.Models.Request.Ddk;
public partial class UploadDdkReportImg
{

    /// <summary>
    /// 多多视频图片文件流
    /// </summary>
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

}

