using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkWeappQrcodeUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("weapp_qrcode_generate_response")]
        public object WeappQrcodeGenerateResponse { get; set; }

        public partial class WeappQrcodeGenerateResponseResponseModel : PddResponseModel
        {

        }

    }
}
