using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkThemePromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 主题活动推广返回对象
        /// </summary>
        [JsonProperty("theme_promotion_url_generate_response")]
        public object ThemePromotionUrlGenerateResponse { get; set; }

        public partial class ThemePromotionUrlGenerateResponseResponseModel : PddResponseModel
        {

        }

    }
}
