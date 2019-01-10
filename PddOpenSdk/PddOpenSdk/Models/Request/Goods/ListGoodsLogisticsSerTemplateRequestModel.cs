using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class ListGoodsLogisticsSerTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("template_type")]
        public int TemplateType { get; set; }
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("query_type")]
        public int QueryType { get; set; }

    }

}
