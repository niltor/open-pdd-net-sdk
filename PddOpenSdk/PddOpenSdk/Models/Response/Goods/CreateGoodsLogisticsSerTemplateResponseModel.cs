using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CreateGoodsLogisticsSerTemplateResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_logistics_ser_template_create_response")]
        public GoodsLogisticsSerTemplateCreateResponseResponseModel GoodsLogisticsSerTemplateCreateResponse { get; set; }
        public partial class GoodsLogisticsSerTemplateCreateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 模版id
            /// </summary>
            [JsonProperty ("template_id")]
            public string TemplateId { get; set; }

        }

    }

}