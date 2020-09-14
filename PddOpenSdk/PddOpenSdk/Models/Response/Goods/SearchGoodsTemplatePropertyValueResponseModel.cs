using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class SearchGoodsTemplatePropertyValueResponseModel : PddResponseModel
    {
        /// <summary>
        /// resposne
        /// </summary>
        [JsonProperty("goods_template_prop_val_search_response")]
        public GoodsTemplatePropValSearchResponseResponseModel GoodsTemplatePropValSearchResponse { get; set; }
        public partial class GoodsTemplatePropValSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 属性值
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; }
                /// <summary>
                /// 属性值id
                /// </summary>
                [JsonProperty("vid")]
                public long? Vid { get; set; }

            }

        }

    }

}
