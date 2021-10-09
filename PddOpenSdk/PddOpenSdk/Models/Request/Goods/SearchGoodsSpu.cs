namespace PddOpenSdk.Models.Request.Goods;
public partial class SearchGoodsSpu
{

    /// <summary>
    /// 类目ID，可以是一二三四级类目，在该类目下进行搜索。
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

    /// <summary>
    /// 标品关键属性精确匹配。和标品标题必须入参其一。
    /// </summary>
    [JsonPropertyName("key_prop")]
    public List<KeyPropModel> KeyProp { get; set; }

    /// <summary>
    /// 标品标题模糊搜索。和关键属性必须入参其一。
    /// </summary>
    [JsonPropertyName("spu_name")]
    public string SpuName { get; set; }
    public partial class KeyPropModel
    {

        /// <summary>
        /// 关键属性的引用属性ID，需要从pdd.cat.rule.get中获取。
        /// </summary>
        [JsonPropertyName("ref_pid")]
        public long? RefPid { get; set; }

        /// <summary>
        /// 属性值单位
        /// </summary>
        [JsonPropertyName("value_unit")]
        public string ValueUnit { get; set; }

        /// <summary>
        /// 关键属性值，需要从pdd.goods.cat.template.get中获取。当要根据关键属性匹配时，和vid必须入参其一。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// 关键属性值ID，需要从pdd.goods.cat.template.get中获取规则。当要根据关键属性匹配时，和value必须入参其一。
        /// </summary>
        [JsonPropertyName("vid")]
        public long? Vid { get; set; }

    }

}

