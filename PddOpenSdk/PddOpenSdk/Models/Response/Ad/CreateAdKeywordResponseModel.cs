using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdKeywordCreateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class CreateAdKeywordResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_keyword_create_response")]
        public AdKeywordCreateResponse AdKeywordCreateResponse { get; set; }
    }


}
