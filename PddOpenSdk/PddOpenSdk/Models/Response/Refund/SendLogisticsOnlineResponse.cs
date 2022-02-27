namespace PddOpenSdk.Models.Response.Refund;
public partial class SendLogisticsOnlineResponse : PddResponseModel
{

    /// <summary>
    /// 发货通知响应对象
    /// </summary>
    [JsonPropertyName("logistics_online_send_response")]
    public LogisticsOnlineSendResponseResponse LogisticsOnlineSendResponse { get; set; }
    public partial class LogisticsOnlineSendResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功，false-失败，true-成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

