namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsSpec
{

    /// <summary>
    /// 叶子类目ID，必须入参level=3时的cat_id,否则无法返回正确的参数
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

}

