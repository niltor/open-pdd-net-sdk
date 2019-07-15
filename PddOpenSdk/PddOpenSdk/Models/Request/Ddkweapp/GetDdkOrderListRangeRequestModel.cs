using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkweapp
{
    public partial class GetDdkOrderListRangeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 支付起始时间，如：2019-05-05 00:00:00
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
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
        /// 支付结束时间，如：2019-05-05 00:00:00
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

    }

}
