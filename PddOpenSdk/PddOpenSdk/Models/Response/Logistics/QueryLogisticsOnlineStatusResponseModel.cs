using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logistics
{
    public partial class QueryLogisticsOnlineStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_online_status_query_response")]
        public LogisticsOnlineStatusQueryResponseResponseModel LogisticsOnlineStatusQueryResponse { get; set; }
        public partial class LogisticsOnlineStatusQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单状态值对应：1,已下单;2,已接单;3,商家已取消;4,快递公司已拒接;5.揽收成功;6.揽收失败;
            /// </summary>
            [JsonProperty("status")]
            public int? Status { get; set; }
            /// <summary>
            /// 状态最新操作时间戳;（Integer）
            /// </summary>
            [JsonProperty("update_time")]
            public long? UpdateTime { get; set; }

        }

    }

}
