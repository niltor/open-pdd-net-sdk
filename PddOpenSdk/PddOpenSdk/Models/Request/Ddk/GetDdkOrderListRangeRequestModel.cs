using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkOrderListRangeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 支付结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        /// <summary>
        /// 上一次的迭代器id(第一次不填)
        /// </summary>
        [JsonProperty("last_order_id")]
        public string LastOrderId { get; set; }
        /// <summary>
        /// 每次请求多少条，建议300
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 支付起始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        /// <summary>
        /// 订单类型：1-推广订单；2-直播间订单
        /// </summary>
        [JsonProperty("query_order_type")]
        public int? QueryOrderType { get; set; }

    }

}
