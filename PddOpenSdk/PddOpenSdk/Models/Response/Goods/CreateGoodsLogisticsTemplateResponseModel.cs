using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsLogisticsTemplateCreateResponse
    {

        /// <summary>
        /// Examples: 1411709
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }
    }

    public class CreateGoodsLogisticsTemplateResponseModel
    {

        /// <summary>
        /// Examples: {"template_id":1411709}
        /// </summary>
        [JsonProperty("goods_logistics_template_create_response")]
        public GoodsLogisticsTemplateCreateResponse GoodsLogisticsTemplateCreateResponse { get; set; }
    }


}
