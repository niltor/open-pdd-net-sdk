using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsCatsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.cats.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 值=0时为顶点cat_id,通过树顶级节点获取cat树
        /// </summary>
        [JsonProperty("parent_cat_id")]
        public int ParentCatId { get; set; }

    }
}
