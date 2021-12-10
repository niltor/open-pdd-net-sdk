namespace PddOpenSdk.Models.Request.Mall;
public partial class PostMallInfoStoreDelete
{

    /// <summary>
    /// 门店ID列表
    /// </summary>
    [JsonPropertyName("store_id_list")]
    public List<long> StoreIdList { get; set; }

}

