namespace PddOpenSdk.Models.Response.Goods;
public partial class CreateGoodsLogisticsTemplateResponse : PddResponseModel
{

    /// <summary>
    /// 返回resposne
    /// </summary>
    [JsonPropertyName("goods_logistics_template_create_response")]
    public GoodsLogisticsTemplateCreateResponseResponse GoodsLogisticsTemplateCreateResponse { get; set; }
    public partial class GoodsLogisticsTemplateCreateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 模版id
        /// </summary>
        [JsonPropertyName("template_id")]
        public long? TemplateId { get; set; }

    }

}

