namespace PddOpenSdk.Models.Request.DdkTools;
public partial class QueryDdkOauthGoodsPid
{

    /// <summary>
    /// 返回的页数
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 返回的每页推广位数量
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 推广位列表，例如：["60005_612"]
    /// </summary>
    [JsonPropertyName("pid_list")]
    public List<string> PidList { get; set; }

}

