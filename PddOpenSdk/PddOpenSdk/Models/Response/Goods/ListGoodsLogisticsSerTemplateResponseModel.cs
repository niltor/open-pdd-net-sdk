using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class ListGoodsLogisticsSerTemplateResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_logistics_ser_template_list_response")]
        public GoodsLogisticsSerTemplateListResponseResponseModel GoodsLogisticsSerTemplateListResponse { get; set; }
        public partial class GoodsLogisticsSerTemplateListResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty ("total")]
            public int Total { get; set; }
            /// <summary>
            /// 列表
            /// </summary>
            [JsonProperty ("list")]
            public List<ListResponseModel> List { get; set; }
            public partial class ListResponseModel : PddResponseModel {
                /// <summary>
                /// 使用情况
                /// </summary>
                [JsonProperty ("using")]
                public int Using { get; set; }
                /// <summary>
                /// 更新时间
                /// </summary>
                [JsonProperty ("update_time")]
                public int UpdateTime { get; set; }
                /// <summary>
                /// 模版名称
                /// </summary>
                [JsonProperty ("template_name")]
                public string TemplateName { get; set; }
                /// <summary>
                /// 模版id
                /// </summary>
                [JsonProperty ("template_id")]
                public string TemplateId { get; set; }

            }

        }

    }

}