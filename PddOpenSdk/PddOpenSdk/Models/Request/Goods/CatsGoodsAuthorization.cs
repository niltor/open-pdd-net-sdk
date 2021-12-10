namespace PddOpenSdk.Models.Request.Goods;
public partial class CatsGoodsAuthorization
{

    /// <summary>
    /// 默认值=0，值=0时为顶点cat_id,通过树顶级节点获取一级类目
    /// </summary>
    [JsonPropertyName("parent_cat_id")]
    public long? ParentCatId { get; set; }

}

