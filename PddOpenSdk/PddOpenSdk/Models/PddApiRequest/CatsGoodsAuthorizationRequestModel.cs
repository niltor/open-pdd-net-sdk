using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CatsGoodsAuthorizationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.authorization.cats
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 默认值=0，值=0时为顶点cat_id,通过树顶级节点获取一级类目
        /// </summary>
        [JsonProperty("parent_cat_id")]
        public int? ParentCatId { get; set; }

    }
}
