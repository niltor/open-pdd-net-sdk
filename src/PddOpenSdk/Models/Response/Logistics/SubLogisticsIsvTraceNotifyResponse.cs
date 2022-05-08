namespace PddOpenSdk.Models.Response.Logistics;
public partial class SubLogisticsIsvTraceNotifyResponse : PddResponseModel
{

    /// <summary>
    /// 订阅响应对象
    /// </summary>
    [JsonPropertyName("logistics_isv_trace_notify_sub")]
    public LogisticsIsvTraceNotifySubResponse LogisticsIsvTraceNotifySub { get; set; }
    public partial class LogisticsIsvTraceNotifySubResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功，false-失败，true-成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

