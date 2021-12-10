namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsSpecId
{

    /// <summary>
    /// 拼多多标准规格ID，可以通过pdd.goods.spec.get接口获取
    /// </summary>
    [JsonPropertyName("parent_spec_id")]
    public long ParentSpecId { get; set; }

    /// <summary>
    /// 商家编辑的规格值，如颜色规格下设置白色属性
    /// </summary>
    [JsonPropertyName("spec_name")]
    public string SpecName { get; set; }

}

