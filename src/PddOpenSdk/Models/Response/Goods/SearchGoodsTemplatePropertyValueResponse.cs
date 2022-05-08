namespace PddOpenSdk.Models.Response.Goods;
public partial class SearchGoodsTemplatePropertyValueResponse : PddResponseModel
{

    /// <summary>
    /// resposne
    /// </summary>
    [JsonPropertyName("goods_template_prop_val_search_response")]
    public GoodsTemplatePropValSearchResponseResponse GoodsTemplatePropValSearchResponse { get; set; }
    public partial class GoodsTemplatePropValSearchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 属性值
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; }

            /// <summary>
            /// 属性值id
            /// </summary>
            [JsonPropertyName("vid")]
            public long? Vid { get; set; }

        }

    }

}

