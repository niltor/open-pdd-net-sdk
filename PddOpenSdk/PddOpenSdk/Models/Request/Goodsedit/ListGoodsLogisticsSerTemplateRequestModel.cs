using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class ListGoodsLogisticsSerTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("template_type")]
        public int TemplateType { get; set; }
        /// <summary>
        /// 查询偏移量
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }
        /// <summary>
        /// 查询大小
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        /// <summary>
        /// 查询类型
        /// </summary>
        [JsonProperty("query_type")]
        public int QueryType { get; set; }

    }

}
