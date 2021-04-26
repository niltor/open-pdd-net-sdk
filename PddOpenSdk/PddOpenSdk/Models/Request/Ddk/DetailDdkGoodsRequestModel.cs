using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class DetailDdkGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
        /// </summary>
        [JsonProperty("goods_sign")]
        public string GoodsSign { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
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
