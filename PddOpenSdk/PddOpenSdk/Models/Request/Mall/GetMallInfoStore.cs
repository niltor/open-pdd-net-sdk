namespace PddOpenSdk.Models.Request.Mall;
public partial class GetMallInfoStore
{

    /// <summary>
    /// 市
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// 区
    /// </summary>
    [JsonPropertyName("district")]
    public string District { get; set; }

    /// <summary>
    /// 分页
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页大小
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 省
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// 门店Id
    /// </summary>
    [JsonPropertyName("store_id")]
    public long? StoreId { get; set; }

    /// <summary>
    /// 门店名称
    /// </summary>
    [JsonPropertyName("store_name")]
    public string StoreName { get; set; }

    /// <summary>
    /// 门店自有编号
    /// </summary>
    [JsonPropertyName("store_number")]
    public string StoreNumber { get; set; }

}

