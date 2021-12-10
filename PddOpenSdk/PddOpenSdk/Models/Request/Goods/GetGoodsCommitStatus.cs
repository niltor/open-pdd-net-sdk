namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsCommitStatus
{

    /// <summary>
    /// goods_commit_id列表
    /// </summary>
    [JsonPropertyName("goods_commit_id_list")]
    public List<long> GoodsCommitIdList { get; set; }

}

