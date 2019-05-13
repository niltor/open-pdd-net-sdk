using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class CrowdSmsAddRequestModel : PddRequestModel
    {
        /// <summary>
        /// 选自定义的时候列表存省代表的id [10]
        /// </summary>
        [JsonProperty("location")]
        public List<long?> Location { get; set; }
        /// <summary>
        /// 地区类型 0-不限 1-江浙沪 2-自定义
        /// </summary>
        [JsonProperty("location_type")]
        public int? LocationType { get; set; }
        /// <summary>
        /// 性别 0-全部 1-男 2-女
        /// </summary>
        [JsonProperty("gender")]
        public int? Gender { get; set; }
        /// <summary>
        /// 商品收藏天数
        /// </summary>
        [JsonProperty("goods_favor_days")]
        public long? GoodsFavorDays { get; set; }
        /// <summary>
        /// 店铺收藏天数
        /// </summary>
        [JsonProperty("mall_favor_days")]
        public long? MallFavorDays { get; set; }
        /// <summary>
        /// 人群名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 店铺无购买天数
        /// </summary>
        [JsonProperty("none_purchase_days")]
        public long? NonePurchaseDays { get; set; }
        /// <summary>
        /// 店铺有购买天数
        /// </summary>
        [JsonProperty("purchase_days")]
        public long? PurchaseDays { get; set; }
        /// <summary>
        /// 历史成交最小次数
        /// </summary>
        [JsonProperty("min_order_count")]
        public long? MinOrderCount { get; set; }
        /// <summary>
        /// 历史成交最大次数
        /// </summary>
        [JsonProperty("max_order_count")]
        public long? MaxOrderCount { get; set; }
        /// <summary>
        /// 首次购买开始时间 "2017-10-19 00:00:00"
        /// </summary>
        [JsonProperty("first_buy_start_time")]
        public string FirstBuyStartTime { get; set; }
        /// <summary>
        /// 首次购买结束时间
        /// </summary>
        [JsonProperty("first_buy_end_time")]
        public string FirstBuyEndTime { get; set; }
        /// <summary>
        /// 店铺有访问天数
        /// </summary>
        [JsonProperty("mall_visit_days")]
        public long? MallVisitDays { get; set; }

    }

}
