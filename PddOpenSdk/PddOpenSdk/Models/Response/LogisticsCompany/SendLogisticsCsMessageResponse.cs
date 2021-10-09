namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class SendLogisticsCsMessageResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_cs_message_send_response")]
    public LogisticsCsMessageSendResponseResponse LogisticsCsMessageSendResponse { get; set; }
    public partial class LogisticsCsMessageSendResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

