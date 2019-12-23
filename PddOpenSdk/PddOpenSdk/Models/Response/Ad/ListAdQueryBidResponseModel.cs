using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdQueryBidResponseModel : PddResponseModel
    {
        /// <summary>
        /// 开平返回
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<OpenApiResponseResponseModel> OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 店铺收藏数
            /// </summary>
            [JsonProperty("mall_fav_num")]
            public long? MallFavNum { get; set; }
            /// <summary>
            /// 千次展现成本
            /// </summary>
            [JsonProperty("cpm")]
            public double? Cpm { get; set; }
            /// <summary>
            /// 广告投资回报率
            /// </summary>
            [JsonProperty("roi")]
            public double? Roi { get; set; }
            /// <summary>
            /// 广告转化支付金额，单位厘
            /// </summary>
            [JsonProperty("gmv")]
            public long? Gmv { get; set; }
            /// <summary>
            /// 广告转化支付订单数
            /// </summary>
            [JsonProperty("order_num")]
            public long? OrderNum { get; set; }
            /// <summary>
            /// 点击单价，单位厘
            /// </summary>
            [JsonProperty("cpc")]
            public double? Cpc { get; set; }
            /// <summary>
            /// 广告消耗,单位厘
            /// </summary>
            [JsonProperty("spend")]
            public long? Spend { get; set; }
            /// <summary>
            /// 广告点击率
            /// </summary>
            [JsonProperty("ctr")]
            public double? Ctr { get; set; }
            /// <summary>
            /// 广告点击数
            /// </summary>
            [JsonProperty("click")]
            public int? Click { get; set; }
            /// <summary>
            /// 广告曝光数
            /// </summary>
            [JsonProperty("impression")]
            public int? Impression { get; set; }
            /// <summary>
            /// 溢价比例（非通投时使用）
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int? BidPremiumRate { get; set; }
            /// <summary>
            /// 溢价绝对值，单位厘（targetType=1，通投时使用这个值）
            /// </summary>
            [JsonProperty("bid")]
            public long? Bid { get; set; }
            /// <summary>
            /// targetType值为6时表示兴趣点名称，targetType值为7时表示人群包名称，targetType值为8时表示地域名称
            /// </summary>
            [JsonProperty("sub_level_target_name")]
            public string SubLevelTargetName { get; set; }
            /// <summary>
            /// targetType值为6时表示兴趣点ID，targetType值为7时表示人群包ID，targetType值为8时表示地域ID
            /// </summary>
            [JsonProperty("sub_level_target_id")]
            public long? SubLevelTargetId { get; set; }
            /// <summary>
            /// 定向类型。1表示通投，2表示访客重定向，3表示相似商品定向，4表示叶子类目定向，5表示相似店铺定向，6表示兴趣点定向，7表示人群包定向，8表示地域定向人群，9表示商品高潜人群，10表示高品质商品偏好人群，11表示大促偏好人群，12表示爱分享人群
            /// </summary>
            [JsonProperty("target_type")]
            public int? TargetType { get; set; }
            /// <summary>
            /// 定向ID
            /// </summary>
            [JsonProperty("bid_id")]
            public long? BidId { get; set; }

        }

    }

}
