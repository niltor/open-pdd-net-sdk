namespace PddOpenSdk.Models.Request.Mall;
public partial class GetMallInfoGroupRemoveStore
{

    /// <summary>
    /// 店铺ID
    /// </summary>
    [JsonPropertyName("group_id")]
    public long GroupId { get; set; }

    /// <summary>
    /// 门店ID列表
    /// </summary>
    [JsonPropertyName("store_id_list")]
    public List<long> StoreIdList { get; set; }

}

