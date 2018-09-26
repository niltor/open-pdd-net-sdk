using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class WeappQrcodeGenerateResponse
    {

        /// <summary>
        /// Examples: "http://xcxcdn.yangkeduo.com/duobaoSpread/2543453159/1000098_11919498/2.jpg"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GenDdkOauthWeappQrcodeUrlResponseModel
    {

        /// <summary>
        /// Examples: {"url":"http://xcxcdn.yangkeduo.com/duobaoSpread/2543453159/1000098_11919498/2.jpg"}
        /// </summary>
        [JsonProperty("weapp_qrcode_generate_response")]
        public WeappQrcodeGenerateResponse WeappQrcodeGenerateResponse { get; set; }
    }


}
