namespace PddOpenSdk.Models.Response.Goods;
public partial class ListGoodsLogisticsSerTemplateResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_logistics_ser_template_list_response")]
    public GoodsLogisticsSerTemplateListResponseResponse GoodsLogisticsSerTemplateListResponse { get; set; }
    public partial class GoodsLogisticsSerTemplateListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 模版id
            /// </summary>
            [JsonPropertyName("template_id")]
            public string TemplateId { get; set; }

            /// <summary>
            /// 模版名称
            /// </summary>
            [JsonPropertyName("template_name")]
            public string TemplateName { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [JsonPropertyName("update_time")]
            public int? UpdateTime { get; set; }

            /// <summary>
            /// 使用情况
            /// </summary>
            [JsonPropertyName("using")]
            public int? Using { get; set; }

        }

    }

}

