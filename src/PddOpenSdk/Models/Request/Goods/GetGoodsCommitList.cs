namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsCommitList
{

    /// <summary>
    /// 草稿状态（0:编辑中,1:审核中,2:审核通过,3:审核驳回）
    /// </summary>
    [JsonPropertyName("check_status")]
    public int CheckStatus { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long? GoodsId { get; set; }

    /// <summary>
    /// 页码，最多不超过100
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// 每页数量，最多不超过100
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

}

