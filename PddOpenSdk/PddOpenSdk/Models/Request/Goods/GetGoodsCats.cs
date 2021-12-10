namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsCats
{

    /// <summary>
    /// 值=0时为顶点cat_id,通过树顶级节点获取cat树
    /// </summary>
    [JsonPropertyName("parent_cat_id")]
    public long ParentCatId { get; set; }

}

