using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class IdAdUnitGetByPlanResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_base_info_List_response")]
        public object AdUnitBaseInfoListResponse { get; set; }

        public partial class AdUnitBaseInfoListResponseResponseModel : PddResponseModel
        {

        }

    }
}
