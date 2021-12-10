namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSpecIdResponse : PddResponseModel
{

    /// <summary>
    /// 生成规格响应对象
    /// </summary>
    [JsonPropertyName("goods_spec_id_get_response")]
    public GoodsSpecIdGetResponseResponse GoodsSpecIdGetResponse { get; set; }
    public partial class GoodsSpecIdGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 自定义规格所属的规格ID
        /// </summary>
        [JsonPropertyName("parent_spec_id")]
        public long? ParentSpecId { get; set; }

        /// <summary>
        /// 生成的自定义规格名称
        /// </summary>
        [JsonPropertyName("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 生成的自定义规格ID
        /// </summary>
        [JsonPropertyName("spec_id")]
        public long? SpecId { get; set; }

    }

}

