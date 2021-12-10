namespace PddOpenSdk.Models.Request.Goods;
public partial class UploadGoodsFilespaceImage
{

    /// <summary>
    /// 图片文件流
    /// </summary>
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

}

