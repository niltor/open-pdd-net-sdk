using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.DdkTools
{
    public partial class DetailDdkOauthGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 商品goodsSign，支持通过goods_sign查询商品。优先使用此字段进行查询
        /// </summary>
        [JsonProperty("goods_sign")]
        public string GoodsSign { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 佣金优惠券对应推广类型，3：专属 4：招商
        /// </summary>
        [JsonProperty("plan_type")]
        public int? PlanType { get; set; }
        /// <summary>
        /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
        /// </summary>
        [JsonProperty("search_id")]
        public string SearchId { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }

    }

}
