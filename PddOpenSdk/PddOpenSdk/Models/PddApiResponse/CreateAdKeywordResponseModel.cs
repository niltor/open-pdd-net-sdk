using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_create_response")]
        public object AdKeywordCreateResponse { get; set; }

        public partial class AdKeywordCreateResponseResponseModel : PddResponseModel
        {

        }

    }
}
