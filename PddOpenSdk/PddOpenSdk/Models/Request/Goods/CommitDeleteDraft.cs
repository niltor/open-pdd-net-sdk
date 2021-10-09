namespace PddOpenSdk.Models.Request.Goods;
public partial class CommitDeleteDraft
{

    /// <summary>
    /// 草稿id
    /// </summary>
    [JsonPropertyName("goods_commit_id")]
    public long GoodsCommitId { get; set; }

}

