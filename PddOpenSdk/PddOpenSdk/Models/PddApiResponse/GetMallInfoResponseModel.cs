using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetMallInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("mall_info_get_response")]
        public object MallInfoGetResponse { get; set; }

        public partial class MallInfoGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
