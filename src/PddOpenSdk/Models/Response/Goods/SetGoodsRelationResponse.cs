namespace PddOpenSdk.Models.Response.Goods;
public partial class SetGoodsRelationResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_relation_set_response")]
    public GoodsRelationSetResponseResponse GoodsRelationSetResponse { get; set; }
    public partial class GoodsRelationSetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

