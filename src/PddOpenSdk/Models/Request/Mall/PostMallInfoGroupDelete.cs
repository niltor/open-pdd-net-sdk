namespace PddOpenSdk.Models.Request.Mall;
public partial class PostMallInfoGroupDelete
{

    /// <summary>
    /// 门店组id列表
    /// </summary>
    [JsonPropertyName("group_id_list")]
    public List<int> GroupIdList { get; set; }

}

