namespace PddOpenSdk.Models.Request.Ddk;
public partial class ListDdkTmcActivity
{

    /// <summary>
    /// 页码 从1开始
    /// </summary>
    [JsonPropertyName("page_num")]
    public int PageNum { get; set; }

    /// <summary>
    /// 每页结果数，默认值: 20 最大50
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 活动开始时间最小时间 格式: "yyyy-MM-dd HH:mm:ss"
    /// </summary>
    [JsonPropertyName("start_time_lower")]
    public string StartTimeLower { get; set; }

    /// <summary>
    /// 活动开始时间最大时间 格式: "yyyy-MM-dd HH:mm:ss"
    /// </summary>
    [JsonPropertyName("start_time_upper")]
    public string StartTimeUpper { get; set; }

}

