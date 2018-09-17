using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdUnitOptStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_opt_status_update_response")]
        public object AdUnitOptStatusUpdateResponse { get; set; }

        public partial class AdUnitOptStatusUpdateResponseResponseModel : PddResponseModel
        {

        }

    }
}
