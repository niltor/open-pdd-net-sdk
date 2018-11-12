using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CreateGoodsLogisticsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回resposne
        /// </summary>
        [JsonProperty("goods_logistics_template_create_response")]
        public GoodsLogisticsTemplateCreateResponseResponseModel GoodsLogisticsTemplateCreateResponse { get; set; }
        public partial class GoodsLogisticsTemplateCreateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 模版id
            /// </summary>
            [JsonProperty("template_id")]
            public long TemplateId { get; set; }

        }

    }

}
