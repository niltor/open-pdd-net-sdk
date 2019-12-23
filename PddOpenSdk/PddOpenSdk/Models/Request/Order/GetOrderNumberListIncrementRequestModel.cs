using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Order
{
    public partial class GetOrderNumberListIncrementRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单类型（是否抽奖订单），0-全部，1-非抽奖订单，2-抽奖订单
        /// </summary>
        [JsonProperty("is_lucky_flag")]
        public int IsLuckyFlag { get; set; }
        /// <summary>
        /// 发货状态，1-待发货，2-已发货待签收，3-已签收，5-全部
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }
        /// <summary>
        /// 必填，最后更新时间开始时间的时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("start_updated_at")]
        public long StartUpdatedAt { get; set; }
        /// <summary>
        /// 必填，最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时; 00 分 00 秒)起至现在的总秒数; PS：开始时间结束时间间距不超过 30 分钟
        /// </summary>
        [JsonProperty("end_updated_at")]
        public long EndUpdatedAt { get; set; }
        /// <summary>
        /// 返回数量，默认 100。最大 100
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 返回页码，默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值；注：必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题。
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 售后状态，1-无售后或售后关闭，2-售后处理中，3-退款中，4-退款成功 5-全部
        /// </summary>
        [JsonProperty("refund_status")]
        public int RefundStatus { get; set; }
        /// <summary>
        /// 订单类型： 0-普通订单、1-定金订单 不传为全部
        /// </summary>
        [JsonProperty("trade_type")]
        public int? TradeType { get; set; }
        /// <summary>
        /// 是否启用has_next的分页方式，如果指定true,则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的的字段，通过此种方式获取增量交易，效率在原有的基础上有80%的提升。
        /// </summary>
        [JsonProperty("use_has_next")]
        public bool? UseHasNext { get; set; }

    }

}
