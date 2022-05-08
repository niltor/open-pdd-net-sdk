namespace PddOpenSdk.Models.Response.Promotion;
public partial class GetPromotionLimitedQualifiedGoodsResponse : PddResponseModel
{

    /// <summary>
    /// 商品列表
    /// </summary>
    [JsonPropertyName("goods_list")]
    public List<GoodsListResponse> GoodsList { get; set; }

    /// <summary>
    /// 总数
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }
    public partial class GoodsListResponse : PddResponseModel
    {

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

    }

}

