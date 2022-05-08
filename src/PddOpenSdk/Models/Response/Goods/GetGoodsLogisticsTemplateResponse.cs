namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsLogisticsTemplateResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_logistics_template_get_response")]
    public GoodsLogisticsTemplateGetResponseResponse GoodsLogisticsTemplateGetResponse { get; set; }
    public partial class GoodsLogisticsTemplateGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 商家运费模板对象列表
        /// </summary>
        [JsonPropertyName("logistics_template_list")]
        public List<LogisticsTemplateListResponse> LogisticsTemplateList { get; set; }

        /// <summary>
        /// 返回的运费模板总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class LogisticsTemplateListResponse : PddResponseModel
        {

            /// <summary>
            /// 计费方式，0-按件计费，1-按重量计费
            /// </summary>
            [JsonPropertyName("cost_type")]
            public int? CostType { get; set; }

            /// <summary>
            /// 最近更新时间
            /// </summary>
            [JsonPropertyName("last_updated_time")]
            public int? LastUpdatedTime { get; set; }

            /// <summary>
            /// 模板id
            /// </summary>
            [JsonPropertyName("template_id")]
            public long? TemplateId { get; set; }

            /// <summary>
            /// 运费模板名称
            /// </summary>
            [JsonPropertyName("template_name")]
            public string TemplateName { get; set; }

        }

    }

}

