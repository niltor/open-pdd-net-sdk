using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsOutPropertyMappingRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多叶子类目id
        /// </summary>
        [JsonProperty("cat_id")]
        public long CatId { get; set; }
        /// <summary>
        /// 外部平台属性名称
        /// </summary>
        [JsonProperty("out_property_name")]
        public string OutPropertyName { get; set; }
        /// <summary>
        /// 外部平台属性值名称
        /// </summary>
        [JsonProperty("out_property_value_name")]
        public string OutPropertyValueName { get; set; }

    }

}
