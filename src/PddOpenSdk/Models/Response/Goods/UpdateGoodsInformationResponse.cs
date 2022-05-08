namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsInformationResponse : PddResponseModel
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("goods_update_response")]
    public GoodsUpdateResponseResponse GoodsUpdateResponse { get; set; }
    public partial class GoodsUpdateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 提交申请的序列id
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// 商品匹配到的标品ID
        /// </summary>
        [JsonPropertyName("matched_spu_id")]
        public long? MatchedSpuId { get; set; }

    }

}

