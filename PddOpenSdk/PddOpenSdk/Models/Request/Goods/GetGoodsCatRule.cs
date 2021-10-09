namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsCatRule
{

    /// <summary>
    /// 类目id
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

}

