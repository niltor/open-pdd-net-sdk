namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsOutPropertyMapping
{

    /// <summary>
    /// 拼多多叶子类目id
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

    /// <summary>
    /// 外部平台属性名称
    /// </summary>
    [JsonPropertyName("out_property_name")]
    public string OutPropertyName { get; set; }

    /// <summary>
    /// 外部平台属性值名称
    /// </summary>
    [JsonPropertyName("out_property_value_name")]
    public string OutPropertyValueName { get; set; }

}

