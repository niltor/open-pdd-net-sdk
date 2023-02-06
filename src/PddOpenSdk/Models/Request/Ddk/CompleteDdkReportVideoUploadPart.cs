namespace PddOpenSdk.Models.Request.Ddk;
public partial class CompleteDdkReportVideoUploadPart
{

    /// <summary>
    /// 标记本次大文件上传的id（init阶段的返回值）
    /// </summary>
    [JsonPropertyName("upload_sign")]
    public string UploadSign { get; set; }

}

