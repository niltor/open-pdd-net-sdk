using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdKeywordUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateAdKeywordResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_keyword_update_response")]
        public AdKeywordUpdateResponse AdKeywordUpdateResponse { get; set; }
    }


}
