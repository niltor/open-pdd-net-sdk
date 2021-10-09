namespace PddOpenSdk.Models.Response.Goods;
public partial class EditGoodsChildSkuResponse : PddResponseModel
{

    /// <summary>
    /// 子sku新增或提交结果
    /// </summary>
    [JsonPropertyName("child_sku_edit_response")]
    public ChildSkuEditResponseResponse ChildSkuEditResponse { get; set; }
    public partial class ChildSkuEditResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 草稿id
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

    }

}

