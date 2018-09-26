using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdUnitOptStatusUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateAdUnitOptStatusResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_unit_opt_status_update_response")]
        public AdUnitOptStatusUpdateResponse AdUnitOptStatusUpdateResponse { get; set; }
    }


}
