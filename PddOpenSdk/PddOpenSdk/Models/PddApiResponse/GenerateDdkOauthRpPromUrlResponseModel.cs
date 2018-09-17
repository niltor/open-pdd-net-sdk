using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkOauthRpPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 红包推广链接返回对象
        /// </summary>
        [JsonProperty("rp_promotion_url_generate_response")]
        public object RpPromotionUrlGenerateResponse { get; set; }

        public partial class RpPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {

        }

    }
}
