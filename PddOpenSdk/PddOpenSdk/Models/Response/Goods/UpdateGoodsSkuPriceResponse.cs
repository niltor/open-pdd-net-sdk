namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsSkuPriceResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_update_sku_price_response")]
    public GoodsUpdateSkuPriceResponseResponse GoodsUpdateSkuPriceResponse { get; set; }
    public partial class GoodsUpdateSkuPriceResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

