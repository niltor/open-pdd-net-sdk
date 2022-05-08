namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsSpu
{

    /// <summary>
    /// 标品所在的类目ID
    /// </summary>
    [JsonPropertyName("cat_id")]
    public string CatId { get; set; }

    /// <summary>
    /// 关键属性
    /// </summary>
    [JsonPropertyName("key_prop")]
    public List<KeyPropModel> KeyProp { get; set; }
    public partial class KeyPropModel
    {

        /// <summary>
        /// 引用属性ID
        /// </summary>
        [JsonPropertyName("ref_pid")]
        public long? RefPid { get; set; }

        /// <summary>
        /// 属性值单位
        /// </summary>
        [JsonPropertyName("value_unit")]
        public string ValueUnit { get; set; }

        /// <summary>
        /// 关键属性值，和vid必须入参其一。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// 关键属性值ID，和value必须入参其一。
        /// </summary>
        [JsonPropertyName("vid")]
        public long? Vid { get; set; }

    }

}

