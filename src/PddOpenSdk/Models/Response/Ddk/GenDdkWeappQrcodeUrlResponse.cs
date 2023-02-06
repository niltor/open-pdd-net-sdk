namespace PddOpenSdk.Models.Response.Ddk;
public partial class GenDdkWeappQrcodeUrlResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("weapp_qrcode_generate_response")]
    public WeappQrcodeGenerateResponseResponse WeappQrcodeGenerateResponse { get; set; }
    public partial class WeappQrcodeGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 单品推广小程序二维码url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

