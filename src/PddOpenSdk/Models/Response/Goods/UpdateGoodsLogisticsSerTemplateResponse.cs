namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsLogisticsSerTemplateResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_logistics_ser_template_update_response")]
    public GoodsLogisticsSerTemplateUpdateResponseResponse GoodsLogisticsSerTemplateUpdateResponse { get; set; }
    public partial class GoodsLogisticsSerTemplateUpdateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 模版id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

    }

}

