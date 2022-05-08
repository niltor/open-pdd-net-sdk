namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsOpt
{

    /// <summary>
    /// 值=0时为顶点opt_id,通过树顶级节点获取opt树
    /// </summary>
    [JsonPropertyName("parent_opt_id")]
    public int ParentOptId { get; set; }

}

