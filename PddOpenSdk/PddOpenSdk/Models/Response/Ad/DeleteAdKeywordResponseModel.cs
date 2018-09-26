using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdKeywordDeleteResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeleteAdKeywordResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_keyword_delete_response")]
        public AdKeywordDeleteResponse AdKeywordDeleteResponse { get; set; }
    }


}
