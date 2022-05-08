namespace PddOpenSdk.Models.Request.Mall;
public partial class PostMallInfoGroupQuery
{

    /// <summary>
    /// 第几页
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 每页多少个
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

}

