namespace PddOpenSdk.Models.Response.Goods;
public partial class CreateGoodsLogisticsSerTemplateResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_logistics_ser_template_create_response")]
    public GoodsLogisticsSerTemplateCreateResponseResponse GoodsLogisticsSerTemplateCreateResponse { get; set; }
    public partial class GoodsLogisticsSerTemplateCreateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 模版id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

    }

}

