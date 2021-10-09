namespace PddOpenSdk.Models.Request.Ad;
public partial class PageAdApiGoodsQuery
{

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("goodsName")]
    public string GoodsName { get; set; }

    /// <summary>
    /// 分页查询，查询第几页
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页查询，每页的大小
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// 计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long? PlanId { get; set; }

}

