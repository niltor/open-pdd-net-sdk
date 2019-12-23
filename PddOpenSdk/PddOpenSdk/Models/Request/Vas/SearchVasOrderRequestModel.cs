using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Vas
{
    public partial class SearchVasOrderRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单创建时间结束，UNIX时间戳（ms 级别）
        /// </summary>
        [JsonProperty("create_time_end")]
        public long? CreateTimeEnd { get; set; }
        /// <summary>
        /// 订单创建时间开始，UNIX时间戳（ms级别）
        /// </summary>
        [JsonProperty("create_time_start")]
        public long? CreateTimeStart { get; set; }
        /// <summary>
        /// 买家店铺id
        /// </summary>
        [JsonProperty("mall_id")]
        public long? MallId { get; set; }
        /// <summary>
        /// 服务订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 订单状态，枚举值，0-未完成，1-已完成，2-已取消，空-全部
        /// </summary>
        [JsonProperty("order_status")]
        public int? OrderStatus { get; set; }
        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 支付完成时间开始，UNIX时间戳（ms 级别）
        /// </summary>
        [JsonProperty("pay_time_end")]
        public long? PayTimeEnd { get; set; }
        /// <summary>
        /// 支付完成时间开始，UNIX时间戳（ms 级别）
        /// </summary>
        [JsonProperty("pay_time_start")]
        public long? PayTimeStart { get; set; }
        /// <summary>
        /// 服务sku_id，可在服务详情页中获取
        /// </summary>
        [JsonProperty("sku_id")]
        public long? SkuId { get; set; }

    }

}
