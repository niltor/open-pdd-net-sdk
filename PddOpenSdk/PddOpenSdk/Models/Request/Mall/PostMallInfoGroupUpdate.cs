namespace PddOpenSdk.Models.Request.Mall;
public partial class PostMallInfoGroupUpdate
{

    /// <summary>
    /// 门店组id
    /// </summary>
    [JsonPropertyName("group_id")]
    public int GroupId { get; set; }

    /// <summary>
    /// 门店组名称
    /// </summary>
    [JsonPropertyName("group_name")]
    public string GroupName { get; set; }

}

