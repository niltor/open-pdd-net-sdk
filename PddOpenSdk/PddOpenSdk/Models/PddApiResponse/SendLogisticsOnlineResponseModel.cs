using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SendLogisticsOnlineResponseModel : PddResponseModel
    {
        /// <summary>
        /// 发货通知响应对象
        /// </summary>
        [JsonProperty("logistics_online_send_response")]
        public object LogisticsOnlineSendResponse { get; set; }

        public partial class LogisticsOnlineSendResponseResponseModel : PddResponseModel
        {

        }

    }
}
