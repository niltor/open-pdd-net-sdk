namespace PddOpenSdk.Models.Request.Ddk;
public partial class QueryDdkPromotionGoods
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long? GoodsId { get; set; }

    /// <summary>
    /// 店铺id
    /// </summary>
    [JsonPropertyName("mall_id")]
    public long? MallId { get; set; }

    /// <summary>
    /// 分页查询页数
    /// </summary>
    [JsonPropertyName("page_number")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// 分页查询页大小
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

}

