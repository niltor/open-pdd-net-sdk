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

    /// <summary>
    /// 查询状态列表
    /// </summary>
    [JsonPropertyName("status_list")]
    public List<int?> StatusList { get; set; }

    /// <summary>
    /// 最后更新开始时间
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public long? UpdateEndTime { get; set; }

    /// <summary>
    /// 最后更新结束时间（最长支持30天）
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public long? UpdateStartTime { get; set; }

}

