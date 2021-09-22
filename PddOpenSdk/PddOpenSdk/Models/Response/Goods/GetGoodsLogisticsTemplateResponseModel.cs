using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsLogisticsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_logistics_template_get_response")]
        public GoodsLogisticsTemplateGetResponseResponseModel GoodsLogisticsTemplateGetResponse { get; set; }
        public partial class GoodsLogisticsTemplateGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商家运费模板对象列表
            /// </summary>
            [JsonProperty("logistics_template_list")]
            public List<LogisticsTemplateListResponseModel> LogisticsTemplateList { get; set; }
            /// <summary>
            /// 返回的运费模板总数
            /// </summary>
            [JsonProperty("total_count")]
            public int? TotalCount { get; set; }
            public partial class LogisticsTemplateListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 计费方式，0-按件计费，1-按重量计费
                /// </summary>
                [JsonProperty("cost_type")]
                public int? CostType { get; set; }
                /// <summary>
                /// 最近更新时间
                /// </summary>
                [JsonProperty("last_updated_time")]
                public int? LastUpdatedTime { get; set; }
                /// <summary>
                /// 模板id
                /// </summary>
                [JsonProperty("template_id")]
                public long? TemplateId { get; set; }
                /// <summary>
                /// 运费模板名称
                /// </summary>
                [JsonProperty("template_name")]
                public string TemplateName { get; set; }

            }

        }

    }

}
