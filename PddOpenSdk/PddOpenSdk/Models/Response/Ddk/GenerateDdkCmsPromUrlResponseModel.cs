using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GenerateDdkCmsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商城推广链接返回对象
        /// </summary>
        [JsonProperty("cms_promotion_url_generate_response")]
        public CmsPromotionUrlGenerateResponseResponseModel CmsPromotionUrlGenerateResponse { get; set; }
        public partial class CmsPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }

        }

    }

}
