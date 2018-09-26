using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdUnitDeleteResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeleteAdUnitResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_unit_delete_response")]
        public AdUnitDeleteResponse AdUnitDeleteResponse { get; set; }
    }


}
