using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SearchGoodsTemplateValueResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("template_value_search_response")]
        public TemplateValueSearchResponseResponseModel TemplateValueSearchResponse { get; set; }

        public partial class TemplateValueSearchResponseResponseModel : PddResponseModel
        {

        }

    }
}
