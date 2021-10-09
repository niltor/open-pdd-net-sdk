namespace PddOpenSdk.Models.Response.Goods;
public partial class AddGoodsResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_add_response")]
    public GoodsAddResponseResponse GoodsAddResponse { get; set; }
    public partial class GoodsAddResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 上传商品的上传序列ID
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

    }

}

