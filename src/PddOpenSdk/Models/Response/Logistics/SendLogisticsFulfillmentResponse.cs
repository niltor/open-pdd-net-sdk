namespace PddOpenSdk.Models.Response.Logistics;
public partial class SendLogisticsFulfillmentResponse : PddResponseModel
{

    /// <summary>
    /// 发货响应对象
    /// </summary>
    [JsonPropertyName("logistics_send_response")]
    public LogisticsSendResponseResponse LogisticsSendResponse { get; set; }
    public partial class LogisticsSendResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 发货失败信息（发货失败时有值）
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否成功，false-失败，true-成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

