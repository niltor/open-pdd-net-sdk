namespace PddOpenSdk.Models.Request.Goods;
public partial class UploadGoodsImg
{

    /// <summary>
    /// 商品图片文件流
    /// </summary>
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

}

