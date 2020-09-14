using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkGoodsRecommendRequestModel : PddRequestModel
    {
        /// <summary>
        /// 0-1.9包邮, 1-今日爆款, 2-品牌清仓,3-相似商品推荐,4-猜你喜欢,5-实时热销,6-实时收益,7-今日畅销,8-高佣榜单，默认1
        /// </summary>
        [JsonProperty("channel_type")]
        public int? ChannelType { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 请求数量；默认值 ： 400
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }
        /// <summary>
        /// 从多少位置开始请求；默认值 ： 0，offset需是limit的整数倍，仅支持整页翻页
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 猜你喜欢场景的商品类目，20100-百货，20200-母婴，20300-食品，20400-女装，20500-电器，20600-鞋包，20700-内衣，20800-美妆，20900-男装，21000-水果，21100-家纺，21200-文具,21300-运动,21400-虚拟,21500-汽车,21600-家装,21700-家具,21800-医药;
        /// </summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }
        /// <summary>
        /// 相似商品推荐场景时必传。商品Id，请求相似商品时，仅取数组的第一位
        /// </summary>
        [JsonProperty("goods_ids")]
        public List<long?> GoodsIds { get; set; }

    }

}
