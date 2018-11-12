using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public partial class SendLogisticsCsMessageResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_message_send_response")]
        public LogisticsCsMessageSendResponseResponseModel LogisticsCsMessageSendResponse { get; set; }
        public partial class LogisticsCsMessageSendResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool IsSuccess { get; set; }

        }

    }

}
