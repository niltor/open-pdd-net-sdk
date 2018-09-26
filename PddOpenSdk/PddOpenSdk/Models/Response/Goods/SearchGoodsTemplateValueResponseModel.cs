using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class TemplatePropertyValueList
    {

        /// <summary>
        /// Examples: 1991
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 4080
        /// </summary>
        [JsonProperty("vid")]
        public int Vid { get; set; }

        /// <summary>
        /// Examples: "vivo"
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TemplateValueSearchResponse
    {

        /// <summary>
        /// Examples: [{"id":1991,"vid":4080,"value":"vivo"}]
        /// </summary>
        [JsonProperty("template_property_value_list")]
        public IList<TemplatePropertyValueList> TemplatePropertyValueList { get; set; }
    }

    public class SearchGoodsTemplateValueResponseModel
    {

        /// <summary>
        /// Examples: {"template_property_value_list":[{"id":1991,"vid":4080,"value":"vivo"}]}
        /// </summary>
        [JsonProperty("template_value_search_response")]
        public TemplateValueSearchResponse TemplateValueSearchResponse { get; set; }
    }


}
