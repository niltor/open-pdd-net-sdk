using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UpdateGoodsLogisticsSerTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_logistics_ser_template_update_response")]
        public GoodsLogisticsSerTemplateUpdateResponseResponseModel GoodsLogisticsSerTemplateUpdateResponse { get; set; }
        public partial class GoodsLogisticsSerTemplateUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 模版id
            /// </summary>
            [JsonProperty("template_id")]
            public string TemplateId { get; set; }

        }

    }

}
