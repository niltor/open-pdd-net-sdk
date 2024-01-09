namespace PddOpenSdk.Models.Request.Goods;
public partial class UploadGoodsVideo
{

    /// <summary>
    /// 视频文件,为文件流
    /// </summary>
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

}

