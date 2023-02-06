namespace PddOpenSdk.Models.Request.Ddk;
public partial class InitDdkReportVideoUploadPart
{

    /// <summary>
    /// 文件对应的contentType，且必须为视频类型
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; }

}

