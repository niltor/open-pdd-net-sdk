namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class UploadLogisticsTicketImage
{

    /// <summary>
    /// 支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持1M
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

}

