using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsCustomTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_custom_template_list_query_response")]
        public object SmsCustomTemplateListQueryResponse { get; set; }

        public partial class SmsCustomTemplateListQueryResponseResponseModel : PddResponseModel
        {

        }

    }
}
