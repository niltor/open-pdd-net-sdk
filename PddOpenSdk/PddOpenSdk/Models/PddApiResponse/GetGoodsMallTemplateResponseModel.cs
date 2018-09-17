using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsMallTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("mall_template_get_response")]
        public object MallTemplateGetResponse { get; set; }

        public partial class MallTemplateGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
