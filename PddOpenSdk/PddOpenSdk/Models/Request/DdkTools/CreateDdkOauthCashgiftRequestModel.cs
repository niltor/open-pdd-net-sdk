using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.DdkTools
{
    public partial class CreateDdkOauthCashgiftRequestModel : PddRequestModel
    {
        /// <summary>
        /// 券批次领取结束时间。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("acquire_end_time")]
        public long AcquireEndTime { get; set; }
        /// <summary>
        /// 券批次领取开始时间。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("acquire_start_time")]
        public long AcquireStartTime { get; set; }
        /// <summary>
        /// 是否自动领券，默认false不自动领券
        /// </summary>
        [JsonProperty("auto_take")]
        public bool? AutoTake { get; set; }
        /// <summary>
        /// 礼金券面额，单位为分
        /// </summary>
        [JsonProperty("coupon_amount")]
        public int CouponAmount { get; set; }
        /// <summary>
        /// 活动持续时间，validity_time_type为 1 时必填。
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// 领券是否过风控，默认true为过风控。
        /// </summary>
        [JsonProperty("fetch_risk_check")]
        public bool? FetchRiskCheck { get; set; }
        /// <summary>
        /// 活动单链接可推广礼金数，默认无限制，最小值为1。
        /// </summary>
        [JsonProperty("link_acquire_limit")]
        public long? LinkAcquireLimit { get; set; }
        /// <summary>
        /// 礼金名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 礼金券数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
        /// <summary>
        /// 商品推广短链
        /// </summary>
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
        /// <summary>
        /// 单用户可领券数量上限，默认为1。
        /// </summary>
        [JsonProperty("user_limit")]
        public int? UserLimit { get; set; }
        /// <summary>
        /// 券批次使用结束时间, validity_time_type为 2 时必填。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("validity_end_time")]
        public long? ValidityEndTime { get; set; }
        /// <summary>
        /// 券批次使用开始时间, validity_time_type为 2 时必填。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("validity_start_time")]
        public long? ValidityStartTime { get; set; }
        /// <summary>
        /// 有效期类型：1-领取后几天内有效；2-固定时间内有效
        /// </summary>
        [JsonProperty("validity_time_type")]
        public int ValidityTimeType { get; set; }

    }

}
