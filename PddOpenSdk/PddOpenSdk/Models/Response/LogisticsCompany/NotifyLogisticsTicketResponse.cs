namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class NotifyLogisticsTicketResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_ticket_notify_response")]
    public LogisticsTicketNotifyResponseResponse LogisticsTicketNotifyResponse { get; set; }
    public partial class LogisticsTicketNotifyResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

