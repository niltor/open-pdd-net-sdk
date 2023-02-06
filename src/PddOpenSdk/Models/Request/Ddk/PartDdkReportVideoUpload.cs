namespace PddOpenSdk.Models.Request.Ddk;
public partial class PartDdkReportVideoUpload
{

    /// <summary>
    /// 当前分片的文件流
    /// </summary>
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

    /// <summary>
    /// 当前分片编号名，从1开始
    /// </summary>
    [JsonPropertyName("part_num")]
    public string PartNum { get; set; }

    /// <summary>
    /// 标记本次大文件上传的id（init阶段的返回值）
    /// </summary>
    [JsonPropertyName("upload_sign")]
    public string UploadSign { get; set; }

}

