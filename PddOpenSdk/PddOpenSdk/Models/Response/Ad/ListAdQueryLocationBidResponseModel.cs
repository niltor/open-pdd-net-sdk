using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdQueryLocationBidResponseModel : PddResponseModel
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
            /// 溢价比例
            /// </summary>
            [JsonProperty("bid_premium_rate")]
            public int? BidPremiumRate { get; set; }
            /// <summary>
            /// 资源位类型（0：基础流量包，1：类目商品页，2：商品详情页，3：营销活动页）
            /// </summary>
            [JsonProperty("location_type")]
            public int? LocationType { get; set; }
            /// <summary>
            /// 资源位ID（基础流量包没有ID）
            /// </summary>
            [JsonProperty("location_bid_id")]
            public long? LocationBidId { get; set; }

        }

    }

}
