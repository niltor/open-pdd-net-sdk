using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkCmsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商城推广链接返回对象
        /// </summary>
        [JsonProperty("cms_promotion_url_generate_response")]
        public object CmsPromotionUrlGenerateResponse { get; set; }

        public partial class CmsPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {

        }

    }
}
