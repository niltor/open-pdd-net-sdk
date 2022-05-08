namespace PddOpenSdk.Models.Response.MallShop;
public partial class InfoTraceSourceUploadCodeResponse : PddResponseModel
{

    /// <summary>
    /// 1成功，0失败
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

}

