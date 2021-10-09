namespace PddOpenSdk.Models.Request.Stock;
public partial class ListStockDepotPriority
{

    /// <summary>
    /// 省id
    /// </summary>
    [JsonPropertyName("province_id")]
    public int? ProvinceId { get; set; }

    /// <summary>
    /// 市id
    /// </summary>
    [JsonPropertyName("city_id")]
    public int? CityId { get; set; }

    /// <summary>
    /// 区id
    /// </summary>
    [JsonPropertyName("district_id")]
    public int? DistrictId { get; set; }

    /// <summary>
    /// 仓库编码
    /// </summary>
    [JsonPropertyName("depot_code")]
    public string DepotCode { get; set; }

    /// <summary>
    /// 每页数据显示数量
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 当前页数 从1开始
    /// </summary>
    [JsonPropertyName("page_num")]
    public int PageNum { get; set; }

}

