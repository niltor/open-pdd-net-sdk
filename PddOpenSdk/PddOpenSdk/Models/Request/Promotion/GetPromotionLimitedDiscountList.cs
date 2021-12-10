namespace PddOpenSdk.Models.Request.Promotion;
public partial class GetPromotionLimitedDiscountList
{

    /// <summary>
    /// 支持多个活动类型的查询。3-限量折扣；12-限时折扣。
    /// </summary>
    [JsonPropertyName("activity_types")]
    public List<int> ActivityTypes { get; set; }

    /// <summary>
    /// 商品id列表
    /// </summary>
    [JsonPropertyName("goods_id_list")]
    public List<long?> GoodsIdList { get; set; }

    /// <summary>
    /// 默认false。true-仅返回活动数量；false-返回活动数量和活动设置数据
    /// </summary>
    [JsonPropertyName("just_count")]
    public bool? JustCount { get; set; }

    /// <summary>
    /// 0:创建时间升序  1:创建时间降序
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// 页码，默认1
    /// </summary>
    [JsonPropertyName("page_no")]
    public int? PageNo { get; set; }

    /// <summary>
    /// 页大小，默认10
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 支持多个活动状态的查询。1-未开始，2-进行中，3-结束|系统结束，4-结束|商家结束，5-提前结束，6-商品处罚中（屏蔽中）。其中3,4,5都算是结束状态。
    /// </summary>
    [JsonPropertyName("status_list")]
    public List<int> StatusList { get; set; }

}

