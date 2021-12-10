namespace PddOpenSdk.Models.Request.Mall;
public partial class GetMallInfoGroupListStore
{

    /// <summary>
    /// 门店组ID
    /// </summary>
    [JsonPropertyName("group_id")]
    public long GroupId { get; set; }

    /// <summary>
    /// 分页页码
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页大小
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

}

