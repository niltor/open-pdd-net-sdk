namespace PddOpenSdk.Models.Request.Ad;
public partial class InfoAdApiUnitTrListAd
{

    /// <summary>
    /// 报表结束日期 格式：yyyy-MM-dd HH:mm:ss
    /// </summary>
    [JsonPropertyName("endDate")]
    public string EndDate { get; set; }

    /// <summary>
    /// 商品id列表
    /// </summary>
    [JsonPropertyName("goodsIds")]
    public List<long?> GoodsIds { get; set; }

    /// <summary>
    /// 排序字段，支持报表字段枚举：0-曝光，1-点击，2-点击率，3-cpc,4-花费，5-订单量,6-gmv，7-roi,8-日期，9-cpm,10-店铺收藏，11-商品收藏
    /// </summary>
    [JsonPropertyName("orderBy")]
    public int? OrderBy { get; set; }

    /// <summary>
    /// 排序类型,0-倒序，1-正序
    /// </summary>
    [JsonPropertyName("sortBy")]
    public int? SortBy { get; set; }

    /// <summary>
    /// 报表开始日期 格式：yyyy-MM-dd HH:mm:ss
    /// </summary>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// 分页大小 默认10
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 分页页数 默认1
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }

}

