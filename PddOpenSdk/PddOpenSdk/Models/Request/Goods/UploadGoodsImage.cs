namespace PddOpenSdk.Models.Request.Goods;
public partial class UploadGoodsImage
{

    /// <summary>
    /// 支持格式有：jpg/jpeg、png等图片格式，注意入参图片必须转码为base64编码
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

}

